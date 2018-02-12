using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Profile : BaseModel
    {
        public Int64 account_id;
        public String full_name;
        public int gender;
        public String dob;
        public String phone;
        public String address;
        public Int64 department_id;

        public String job_title;
        public String join_date;
        public String contract_code;
        public String staff_code;

        public Profile()
        {
        }

        public Profile(Int64 id, string full_name, int gender, string dob, string phone, string address, long department_id, string job_title, string join_date, string contract_code, string staff_code, DateTime createdAt, DateTime updatedAt)
            : base(id, createdAt, updatedAt)
        {
            this.full_name = full_name;
            this.gender = gender;
            this.dob = dob;
            this.phone = phone;
            this.address = address;
            this.department_id = department_id;
            this.job_title = job_title;
            this.join_date = join_date;
            this.contract_code = contract_code;
            this.staff_code = staff_code;
        }
    }
}
