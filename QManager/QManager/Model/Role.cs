using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Role : BaseModel
    {
        public virtual String name { get; set; }
        public virtual String description { get; set; }
        public virtual Int64 deparment_id { get; set; }

        public Role()
        {

        }

        public Role(string name, string description, Int64 deparment_id)
        {
            this.name = name;
            this.description = description;
            this.deparment_id = deparment_id;
        }
    }
}
