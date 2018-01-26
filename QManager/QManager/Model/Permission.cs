using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Permission : BaseModel
    {
        public virtual Int64 function_id { get; set; }
        public virtual int role { get; set; }
        public virtual Int64 deparment_id { get; set; }
        public virtual int permission { get; set; }
    }
}
