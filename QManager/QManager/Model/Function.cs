using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Function : BaseModel
    {
        public String name;
        public String description;

        public Function()
        {
        }

        public Function(Int64 id, string name, string description, DateTime createdAt, DateTime updatedAt)
            : base(id, createdAt, updatedAt)
        {
            this.name = name;
            this.description = description;
        }
    }
}
