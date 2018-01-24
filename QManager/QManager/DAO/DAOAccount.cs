using MySql.Data.MySqlClient;
using QManager.DAO.Script;
using QManager.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QManager
{
    public static class DAOAccount
    {
        public static List<Account> GetAccountById(Int64 id)
        {
            List<Account> list = new List<Account>();
            MySqlCommand command = DBConnection.GetInstance().GetCommand();
            command.CommandText = SQLAccount.GET_BY_ID;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue(SQLAccount.KEY_ID, id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {

                }
            }
            return list;
        }

        public static List<Account> GetAll()
        {
            List<Account> list = new List<Account>();
            MySqlCommand command = DBConnection.GetInstance().GetCommand();
            command.CommandText = SQLAccount.GET_ALL;
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Int64 id = reader.GetInt64(0);
                String id = reader.GetInt64(1);
                Int64 id = reader.GetInt64(2);
                Int64 id = reader.GetInt64(3);
                Int64 id = reader.GetInt64(4);
                Int64 id = reader.GetInt64(5);
                Int64 id = reader.GetInt64(4);
                Account account = new Account(
                    )
                
            }
            return list;
        }

        public static int AddAccount(string username, string password, string email, int status, int role)
        {
            MySqlCommand command = DBConnection.GetInstance().GetCommand();
            command.CommandText = SQLAccount.INSERT;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue(SQLAccount.KEY_USERNAME, username);
            command.Parameters.AddWithValue(SQLAccount.KEY_PASSWORD, password);
            command.Parameters.AddWithValue(SQLAccount.KEY_EMAIL, email);
            command.Parameters.AddWithValue(SQLAccount.KEY_STATUS, status);
            command.Parameters.AddWithValue(SQLAccount.KEY_ROLE, role);
            int row = command.ExecuteNonQuery();
            return row;
        }
    }
}
