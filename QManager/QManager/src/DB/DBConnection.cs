using System;

using MySql.Data.MySqlClient;
using System.Data;
using QManager.Properties;
using QManager.DB;

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
                mainConnection.Close();
            }
            catch (MySqlException mysqle)
            {
                Console.WriteLine(mysqle.Message);
            }
        }

        public static DBConnection getInstance(){
            return instance;
        }

        public void DoQueryCommand(string commandText,MySqlCommand cmd)
        {
            cmd.CommandText = SQLCommands.GET_ALL_TEST;
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0}, {1}",
                    reader.GetInt32(0), reader.GetString(1))
                );
            }

            reader.Close();
        }

        public void InsertCommand(MySqlCommand cmd, string name)
        {
            cmd.CommandText = "INSERT INTO test (testcol) VALUES (?name)";
            cmd.Parameters.AddWithValue("?name", name);
            cmd.ExecuteNonQuery();
        }
    }
}
