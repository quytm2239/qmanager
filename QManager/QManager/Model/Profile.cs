using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Profile : BaseModel
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
    }
}
