using System;

namespace QManager.Model
{
    public class Department : BaseModel
    {
        public virtual String name { get; set; }
        public virtual String description { get; set; }

        public Department()
        {

        }

        public Department(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
