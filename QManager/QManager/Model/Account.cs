using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    //https://www.devart.com/dotconnect/mysql/docs/Devart.Data.MySql~Devart.Data.MySql.MySqlType.html#
    public class Account : BaseModel
    {
        public virtual String username { get; set; }
        public virtual String password { get; set; }
        public virtual String email { get; set; }
        public virtual int status { get; set; }
        public virtual int role { get; set; }

        public Account()
        {
           
        }

        public Account(string username, string password, string email, int status, int role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.status = status;
            this.role = role;
        }
    }
}
