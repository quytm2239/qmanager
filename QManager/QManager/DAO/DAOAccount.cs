using QManager.Model;
using System;
using System.Collections.Generic;
using NHibernate;

namespace QManager.DAO
{
    public class DAOAccount : BaseDAO
    {
        public static IList<Account> GetAll()
        {
            IList<Account> objList;
            using (var session = GetSession())
            {
                objList = session.QueryOver<Account>().List<Account>();
            }
            return objList;
        }

        public static IList<Account> GetById(Int64 id)
        {
            IList<Account> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Account>()
                    .Where(a => a.id == id)
                    .List<Account>();
            }
            return objList;
        }

        public static IList<Account> GetByUsername(String username)
        {
            IList<Account> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Account>()
                    .Where(a => a.username == username)
                    .List<Account>();
            }
            return objList;
        }

        public static IList<Account> GetByEmail(String email)
        {
            IList<Account> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Account>()
                    .Where(a => a.email == email)
                    .List<Account>();
            }
            return objList;
        }
    }
}
