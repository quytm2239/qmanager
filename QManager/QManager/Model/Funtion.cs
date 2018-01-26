using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QManager.Model
{
    class Funtion : BaseModel
    {
        public virtual String name { get; set; }
        public virtual String description { get; set; }
    }
}
