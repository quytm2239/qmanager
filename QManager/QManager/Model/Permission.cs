using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Permission : BaseModel
    {
        public virtual Int64 function_id { get; set; }
        public virtual int role { get; set; }
        public virtual Int64 deparment_id { get; set; }
        public virtual int permission { get; set; }

        public Permission()
        {
        }

        public Permission(long function_id, int role, long deparment_id, int permission)
        {
            this.function_id = function_id;
            this.role = role;
            this.deparment_id = deparment_id;
            this.permission = permission;
        }
    }
}
