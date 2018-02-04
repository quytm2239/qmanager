using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Profile : BaseModel
    {
        public virtual Int64 account_id { get; set; }
        public virtual String full_name { get; set; }
        public virtual int gender { get; set; }
        public virtual String dob { get; set; }
        public virtual String phone { get; set; }
        public virtual String address { get; set; }
        public virtual Int64 department_id { get; set; }

        public virtual String job_title { get; set; }
        public virtual String join_date { get; set; }
        public virtual String contract_code { get; set; }
        public virtual String staff_code { get; set; }

        public Profile()
        {
        }

        public Profile(string full_name, int gender, string dob, string phone, string address, long department_id, string job_title, string join_date, string contract_code, string staff_code)
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
