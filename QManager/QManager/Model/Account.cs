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
        public String username;
        public String password;
        public String email;
        public int status;
        public int role;

        public Account()
        {

        }

        public Account(Int64 id, string username, string password, string email, int status, int role, DateTime createdAt, DateTime updatedAt)
            : base(id, createdAt, updatedAt)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.status = status;
            this.role = role;
        }
    }
}
