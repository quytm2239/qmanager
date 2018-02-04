using FluentNHibernate.Mapping;
using QManager.CustomProperties;
using QManager.Model;

namespace QManager.ModelMapping
{
    class ProfileMap : ClassMap<Profile>
    {
        public ProfileMap()
        {
            Table(TABLE_NAME.PROFILE);
            Id(x => x.id);
            Map(x => x.account_id);
            Map(x => x.full_name);
            Map(x => x.gender);
            Map(x => x.dob);
            Map(x => x.phone);
            Map(x => x.department_id);
            Map(x => x.job_title);
            Map(x => x.join_date);
            Map(x => x.contract_code);
            Map(x => x.staff_code);
            Map(x => x.createdAt).Column("createdAt").ReadOnly();
            Map(x => x.updatedAt).Column("updatedAt").ReadOnly();
        }
    }
}
