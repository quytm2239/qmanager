using QManager.Model;
using System;
using System.Collections.Generic;

namespace QManager.DAO
{
    class DAOProfile : BaseDAO
    {
        public static IList<Profile> GetAll()
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session.QueryOver<Profile>().List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetById(Int64 id)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.id == id)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByAccountId(Int64 account_id)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.account_id == account_id)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByDepartmentId(Int64 department_id)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.department_id == department_id)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByFullName(String full_name)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.full_name == full_name)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByJobTitle(String job_title)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.job_title == job_title)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByJoinDate(String join_date)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.join_date == join_date)
                    .List<Profile>();
            }
            return objList;
        }

        public static IList<Profile> GetByPhone(String phone)
        {
            IList<Profile> objList;
            using (var session = GetSession()) {
                objList = session
                    .QueryOver<Profile>()
                    .Where(a => a.phone == phone)
                    .List<Profile>();
            }
            return objList;
        }
    }
}
