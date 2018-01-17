using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Account
    {
        private Int64 id;
        private String username;
        private String password;
        private String email;
        private int status;
        private int role;
        private DateTime createAt;
        private DateTime updatedAt;

        public Account()
        {

        }

        public Account(long id, string username, string password, string email, int status, int role, DateTime createAt, DateTime updatedAt)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.status = status;
            this.role = role;
            this.createAt = createAt;
            this.updatedAt = updatedAt;
        }
    }
}
