using FluentNHibernate.Mapping;
using QManager.CustomProperties;
using QManager.Model;

namespace QManager.ModelMapping
{
    class PermissionMap : ClassMap<Permission>
    {
        public PermissionMap()
        {
            Table(TABLE_NAME.PERMISSION);
            Id(x => x.id);
            Map(x => x.function_id);
            Map(x => x.role);
            Map(x => x.deparment_id);
            Map(x => x.permission);
            Map(x => x.createdAt).Column("createdAt").ReadOnly();
            Map(x => x.updatedAt).Column("updatedAt").ReadOnly();
        }
    }
}
