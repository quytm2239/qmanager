using System;

using MySql.Data.MySqlClient;
using System.Data;
using QManager.Properties;
using System.Collections.Generic;

namespace QManager
{
    class DBConnection
    {
        private MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
        private static readonly DBConnection instance = new DBConnection();
        private MySqlConnection mainConnection;
        private MySqlConnection backgroundConnection;
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
        }

        public void CheckConnectity()
        {
            try
            {
                mainConnection.Open();
                Console.WriteLine("Connected to: " + connectionStringBuilder.Server +":"+ connectionStringBuilder.Port + " SUCCESSFULLY!");
                //mainConnection.Close();
            }
            catch (MySqlException mysqle)
            {
                Console.WriteLine(mysqle.Message);
            }
        }

        public static DBConnection getInstance(){
            return instance;
        }

        public MySqlCommand getCommand()
        {
            ConnectionState state = mainConnection.State;

            
            MySqlCommand command = new MySqlCommand();
            
            switch (state)
            {
                case ConnectionState.
            }
        }
    }
}
