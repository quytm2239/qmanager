using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QManager.DBConnection
{
    class DBConnection
    {
        private MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();

        private string HOST = "35.201.228.124";
        private static DBConnection instance;
        private DBConnection()
        {
            connectionStringBuilder.Server = HOST;
            connectionStringBuilder.Database = Database;
            connectionStringBuilder.UserID = UserId;
            connectionStringBuilder.Password = Pass;
            connectionStringBuilder.MinimumPoolSize = 100;
        }

        public DBConnection getInstance(){
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
    }
}
