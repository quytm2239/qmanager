using QManager.Model;
using System;
using System.Collections.Generic;

namespace QManager.DAO
{
    public class DAODepartment : BaseDAO
    {
        public static IList<Department> GetAll()
        {
            IList<Department> objList;
            using (var session = GetSession()) {
                objList = session.QueryOver<Department>().List<Department>();
            }
            return objList;
        }

        public static IList<Department> GetById(Int64 id)
        {
            IList<Department> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Department>()
                    .Where(a => a.id == id)
                    .List<Department>();
            }
            return objList;
        }

        public static IList<Department> GetByName(String name)
        {
            IList<Department> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Department>()
                    .Where(a => a.name == name)
                    .List<Department>();
            }
            return objList;
        }
    }
}
