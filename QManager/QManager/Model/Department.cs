using System;

namespace QManager.Model
{
    public class Department : BaseModel
    {
        public String name;
        public String description;

        public Department()
        {

        }

        public Department(Int64 id, string name, string description, DateTime createdAt, DateTime updatedAt)
            : base(id, createdAt, updatedAt)
        {
            this.name = name;
            this.description = description;
        }
    }
}
