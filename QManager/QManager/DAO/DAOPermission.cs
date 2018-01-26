using QManager.Model;
using System;
using System.Collections.Generic;

namespace QManager.DAO
{
    class DAOPermission : BaseDAO
    {
        public static IList<Permission> GetAll()
        {
            IList<Permission> objList;
            using (var session = GetSession())
            {
                objList = session.QueryOver<Permission>().List<Permission>();
            }
            return objList;
        }

        public static IList<Permission> GetById(Int64 id)
        {
            IList<Permission> objList;
            using (var session = GetSession())
            {
                objList = session
                    .QueryOver<Permission>()
                    .Where(a => a.id == id)
                    .List<Permission>();
            }
            return objList;
        }

        public static IList<Permission> GetByFunctionId(Int64 function_id)
        {
            IList<Permission> permissionList;
            using (var session = GetSession())
            {
                permissionList = session
                    .QueryOver<Permission>()
                    .Where(a => a.function_id == function_id)
                    .List<Permission>();
            }
            return permissionList;
        }

        public static IList<Permission> GetByDepartmentId(Int64 department_id)
        {
            IList<Permission> permissionList;
            using (var session = GetSession())
            {
                permissionList = session
                    .QueryOver<Permission>()
                    .Where(a => a.deparment_id == department_id)
                    .List<Permission>();
            }
            return permissionList;
        }

        public static IList<Permission> GetByRole(int role)
        {
            IList<Permission> permissionList;
            using (var session = GetSession())
            {
                permissionList = session
                    .QueryOver<Permission>()
                    .Where(a => a.role == role)
                    .List<Permission>();
            }
            return permissionList;
        }

        public static IList<Permission> GetByPermission(int permission)
        {
            IList<Permission> permissionList;
            using (var session = GetSession())
            {
                permissionList = session
                    .QueryOver<Permission>()
                    .Where(a => a.permission == permission)
                    .List<Permission>();
            }
            return permissionList;
        }
    }
}
