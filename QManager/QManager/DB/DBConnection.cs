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
        private bool IsReady = false;
        public EventHandler NetworkError;
        private DBConnection()
        {
            connectionStringBuilder.Server = Settings.Default.DBHost;
            connectionStringBuilder.Database = Settings.Default.DBSchema;
            connectionStringBuilder.UserID = Settings.Default.DBUser;
            connectionStringBuilder.Password = Settings.Default.DBPass;
            connectionStringBuilder.MinimumPoolSize = Settings.Default.DBMinPoolSize;
            connectionStringBuilder.MaximumPoolSize = Settings.Default.DBMaxPoolSize;

            mainConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);
            backgroundConnection = new MySqlConnection(connectionStringBuilder.ConnectionString);

            mainConnection.StateChange += MainConnection_StateChange;
            backgroundConnection.StateChange += BackgroundConnection_StateChange;
        }

        public static DBConnection GetInstance() => instance;

        public void CheckConnectity()
        {
            DoConnection();
            if (mainConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connected to: " + connectionStringBuilder.Server +":"+ connectionStringBuilder.Port + " SUCCESSFULLY!");
            }
            CreateTimerToCheckDBConnection();
        }

        private void MainConnection_StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine(value: "MAIN_CONNECTION: " + e.CurrentState);
            switch (e.CurrentState)
            {
                case ConnectionState.Broken:
                case ConnectionState.Closed:
                    if (IsReady && !Program.IsAppClosed)
                    {
                        DoConnection();
                    }
                    break;
                case ConnectionState.Open:
                    IsReady = true;
                    break;
                default:
                    break;
            }
        }

        private void BackgroundConnection_StateChange(object sender, StateChangeEventArgs e) => Console.WriteLine(value: "BACKGROUND STATE: " + e.CurrentState);

        private async void DoConnection()
        {
            try
            {
                await mainConnection.OpenAsync();
                await backgroundConnection.OpenAsync();
            }
            catch (MySqlException mysqle)
            {
                Console.WriteLine(mysqle.Message);
            }
        }

        public MySqlCommand GetCommand()
        {
            while(mainConnection.State == ConnectionState.Connecting) {}
            MySqlCommand command = new MySqlCommand
            {
                Connection = mainConnection
            };
            return command;
        }

        private void CreateTimerToCheckDBConnection()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(mainConnection.State);
            NetworkError?.Invoke(this, EventArgs.Empty);
        }
    }
}
