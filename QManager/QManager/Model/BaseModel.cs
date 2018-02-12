using System;

namespace QManager.Model
{
    public class BaseModel
    {
        public Int64 id;
        public DateTime createdAt;
        public DateTime updatedAt;

        public BaseModel()
        {
        }

        public BaseModel(Int64 id, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
