using System;
using QManager.Model;
using QManager.DAO;
using NHibernate;

namespace QManager.BusinessLogic
{
    public class HRManager
    {
        public static bool AddMember(string username, string password, string email, int role,
            string full_name, int gender, string dob, string phone, string address,
            long department_id, string job_title, string join_date, string contract_code, string staff_code)
        {
            Account account = new Account(username, password, email, 0, role);
            Profile profile = new Profile(full_name, gender, dob, phone, address, department_id, job_title, join_date, contract_code, staff_code);

            Console.WriteLine("[START] Transaction!");
            using (var session = BaseDAO.GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    try {
                        session.Save(account);
                        profile.account_id = account.id;
                        session.Save(profile);
                        transaction.Commit();
                        Console.WriteLine("[FINISH] Transaction!");
                        return true;
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        Console.WriteLine("[FAIL] Transaction!");
                        return false;
                    }
                }
            }
        }
    }
}
