using System;

namespace QManager.Model
{
    class Department : BaseModel
    {
        public virtual String name { get; set; }
        public virtual String description { get; set; }
    }
}
