﻿using FluentNHibernate.Mapping;
using QManager.CustomProperties;
using QManager.Model;

namespace QManager.ModelMapping
{
    class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Table(TABLE_NAME.ACCOUNT);
            Id(x => x.id);
            Map(x => x.username);
            Map(x => x.password);
            Map(x => x.email);
            Map(x => x.status);
            Map(x => x.role);
            Map(x => x.createdAt).Column("createdAt").ReadOnly();
            Map(x => x.updatedAt).Column("updatedAt").ReadOnly();
        }
    }
}
