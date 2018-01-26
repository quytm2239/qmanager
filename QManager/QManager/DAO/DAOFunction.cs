using QManager.Model;
using System;
using System.Collections.Generic;

namespace QManager.DAO
{
    public class DAOFunction : BaseDAO
    {
        public static IList<Function> GetAll()
        {
            IList<Function> objList;
            using (var session = GetSession())
            {
                objList = session.QueryOver<Function>().List<Function>();
            }
            return objList;
        }

        public static IList<Function> GetById(Int64 id)
        {
            IList<Function> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Function>()
                    .Where(a => a.id == id)
                    .List<Function>();
            }
            return objList;
        }

        public static IList<Function> GetByName(String name)
        {
            IList<Function> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Function>()
                    .Where(a => a.name == name)
                    .List<Function>();
            }
            return objList;
        }
    }
}
