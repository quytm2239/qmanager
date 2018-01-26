using FluentNHibernate.Mapping;
using QManager.CustomProperties;
using QManager.Model;

namespace QManager.ModelMapping
{
    class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Table(TABLE_NAME.DEPARTMENT);
            Id(x => x.id);
            Map(x => x.name);
            Map(x => x.description);
            Map(x => x.createdAt).Column("createdAt").ReadOnly();
            Map(x => x.updatedAt).Column("updatedAt").ReadOnly();
        }
    }
}
