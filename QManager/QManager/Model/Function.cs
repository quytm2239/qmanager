using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    public class Function : BaseModel
    {
        public virtual String name { get; set; }
        public virtual String description { get; set; }

        public Function()
        {
        }

        public Function(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
