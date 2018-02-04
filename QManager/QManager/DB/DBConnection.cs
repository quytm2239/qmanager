using System;

using MySql.Data.MySqlClient;
using System.Data;
using QManager.Properties;
using System.Timers;

namespace QManager
{
    class DBConnection
    {
        private MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
        private static readonly DBConnection instance = new DBConnection();
        private MySqlConnection mainConnection;
        private MySqlConnection backgroundConnection;
        private MySqlConnection testConnection;
        private bool IsDisconnected = false;
        public EventHandler NetworkError;
        private DBConnection()
        {
            connectionStringBuilder.Server = Settings.Default.DBHost;
            connectionStringBuilder.Database = Settings.Default.DBSchema;
            connectionStringBuilder.UserID = Settings.Default.DBUser;
            connectionStringBuilder.Password = Settings.Default.DBPass;
            connectionStringBuilder.MinimumPoolSize = Settings.Default.DBMinPoolSize;
            connectionStringBuilder.MaximumPoolSize = Settings.Default.DBMaxPoolSize;
            connectionStringBuilder.ConnectionTimeout = 1;

            mainConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);
            backgroundConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);
            testConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);

            mainConnection.StateChange += MainConnection_StateChange;
            backgroundConnection.StateChange += BackgroundConnection_StateChange;
            testConnection.StateChange += TestConnection_StateChange;
        }

        public static DBConnection GetInstance() => instance;

        public void CheckConnectity()
        {
            Console.WriteLine("CheckConnectity()");
            StartAwaitConnection();
            if (mainConnection.State == ConnectionState.Open) {
                Console.WriteLine("Connected to: " + connectionStringBuilder.Server + ":" + connectionStringBuilder.Port + " SUCCESSFULLY!");
            }
            CreateTimerToCheckDBConnection();
        }

        private void MainConnection_StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("MainConnection_StateChange()");
            Console.WriteLine(value: "MAIN_CONNECTION: " + e.CurrentState);
        }
        private void BackgroundConnection_StateChange(object sender, StateChangeEventArgs e) => Console.WriteLine(value: "BACKGROUND STATE: " + e.CurrentState);
        private void TestConnection_StateChange(object sender, StateChangeEventArgs e) => Console.WriteLine(value: "TEST STATE: " + e.CurrentState);

        private async void StartAwaitConnection()
        {
            Console.WriteLine("StartConnection()");
            if (
                mainConnection.State == ConnectionState.Connecting || backgroundConnection.State == ConnectionState.Connecting ||
                mainConnection.State == ConnectionState.Open || backgroundConnection.State == ConnectionState.Open)
                return;
            try {
                await mainConnection.OpenAsync();
                //await backgroundConnection.OpenAsync();
            } catch (MySqlException mysqle) {
                Console.WriteLine(mysqle.Message);
                IsDisconnected = true;
            }
        }

        private async void StopAwaitConnection()
        {
            Console.WriteLine("StopConnection()");
            if (mainConnection.State == ConnectionState.Closed
                || backgroundConnection.State == ConnectionState.Closed) return;
            await mainConnection.CloseAsync();
            await backgroundConnection.CloseAsync();
        }

        public MySqlCommand GetCommand()
        {
            while (mainConnection.State == ConnectionState.Connecting) { }
            MySqlCommand command = new MySqlCommand {
                Connection = mainConnection
            };
            return command;
        }

        private void CreateTimerToCheckDBConnection()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1500;
            aTimer.Enabled = true;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("OnTimedEvent()");
            ScheduleCheckDBConnectivityAsync();
        }

        private async void ScheduleCheckDBConnectivityAsync()
        {
            switch (testConnection.State) {
                case ConnectionState.Closed:
                case ConnectionState.Broken:
                try { await testConnection.OpenAsync(); } catch (Exception e) {
                    Console.WriteLine(value: e.Message);
                    if (NetworkError != null) NetworkError.Invoke(testConnection, EventArgs.Empty);

                    //This will avoid Application terminated 
                    //when Start app with NO Network Connection or DB Connection
                    try {
                        testConnection.Close();
                        mainConnection.Close();
                    } catch (NotSupportedException nse) { Console.WriteLine(value: nse.Message); } catch (NullReferenceException nre) { Console.WriteLine(value: nre.Message); }
                    //--------------------------------------------------------//

                    IsDisconnected = true;
                }
                break;
                case ConnectionState.Connecting:
                if (IsDisconnected && !Program.IsAppClosed) {
                    testConnection.Close();
                    try { testConnection.Open(); } catch (Exception e) {
                        Console.WriteLine(value: e.Message);
                        testConnection.Close();
                        mainConnection.Close();
                        IsDisconnected = true;
                    }
                }
                break;
                case ConnectionState.Open:
                if (NetworkError != null) NetworkError.Invoke(testConnection, EventArgs.Empty);
                if (IsDisconnected && !Program.IsAppClosed) {
                    await mainConnection.OpenAsync();
                    IsDisconnected = false;
                }

                //This will avoid Application terminated 
                //when Start app with NO Network Connection or DB Connection
                try { testConnection.Close(); } catch (NotSupportedException nse) { Console.WriteLine(value: nse.Message); } catch (NullReferenceException nre) { Console.WriteLine(value: nre.Message); }
                //--------------------------------------------------------//
                break;
                case ConnectionState.Executing:
                case ConnectionState.Fetching:
                break;
            }
        }
    }
}
