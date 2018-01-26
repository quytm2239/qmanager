using MySql.Data.MySqlClient;
using QManager.DAO.Script;
using QManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using NHibernate;
using QManager.DAO;

namespace QManager
{
    public class DAOAccount : BaseDAO
    {
        public static IList<Account> GetAccountByIdOrUsername(Int64 id, String username)
        {
            IList<Account> customersList;
            using (var session = GetSession())
            {
                customersList = session
                    .QueryOver<Account>()
                    .Where(a =>
                        a.id == id || a.username == username
                    )
                    .List<Account>();
            }
            return customersList;
        }

        public static IList<Account> GetAll()
        {
            IList<Account> customersList;
            using (var session = GetSession())
            {
                customersList = session.QueryOver<Account>().List<Account>();
            }
            return customersList;
        }

        public static long AddAccount(string username, string password, string email, int status, int role)
        {
            Account account = new Account(username,password,email,status,role);
            using (var session = GetSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(account);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            return account.id;
        }
    }
}
