using NHibernate;
using QManager.DB;

namespace QManager.DAO
{
    public class BaseDAO
    {
        public static readonly ISessionFactory SessionFactory = FluentNHibernateConnection.CreateSessionFactory();
        public static ISession GetSession() => SessionFactory.OpenSession();
    }
}
