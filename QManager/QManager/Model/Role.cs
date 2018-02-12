using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Role : BaseModel
    {
        public String name;
        public String description;
        public Int64 department_id;

        public Role()
        {

        }

        public Role(Int64 id, string name, string description, Int64 department_id, DateTime createdAt, DateTime updatedAt)
            : base(id, createdAt, updatedAt)
        {
            this.name = name;
            this.description = description;
            this.department_id = department_id;
        }
    }
}
