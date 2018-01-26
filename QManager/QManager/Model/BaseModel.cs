using System;

namespace QManager.Model
{
    public class BaseModel
    {
        public virtual Int64 id { get; protected set; }
        public virtual DateTime createdAt { get; protected set; }
        public virtual DateTime updatedAt { get; protected set; }

        public BaseModel()
        {

        }
    }
}
