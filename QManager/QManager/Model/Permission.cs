using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Permission : BaseModel
    {
        public Int64 function_id;
        public int role;
        public Int64 department_id;
        public int permission_config;

        public Permission()
        {
        }

        public Permission(Int64 id, long function_id, int role, long department_id, int permission_config, DateTime createdAt, DateTime updatedAt) 
            : base(id, createdAt, updatedAt)
        {
            this.function_id = function_id;
            this.role = role;
            this.department_id = department_id;
            this.permission_config = permission_config;
        }
    }
}
