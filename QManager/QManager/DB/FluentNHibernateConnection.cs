using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cache;
using QManager.Properties;
using QManager.ModelMapping;

namespace QManager.DB
{
    class FluentNHibernateConnection
    {
        //https://books.google.com.vn/books?id=iqJNCgAAQBAJ&pg=PA125&lpg=PA125&dq=Add+all+fluent+mappings+in+the+assembly+that+contains+T&source=bl&ots=SFGTjAcKaG&sig=A6JCDj4u7niseCevHO_FQ1ZvNmQ&hl=vi&sa=X&ved=0ahUKEwi7tK7Yn_LYAhVIrY8KHazpAAgQ6AEIRTAD#v=onepage&q=Add%20all%20fluent%20mappings%20in%20the%20assembly%20that%20contains%20T&f=false
        public static ISessionFactory CreateSessionFactory()
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder {
                Server = Settings.Default.DBHost,
                Database = Settings.Default.DBSchema,
                UserID = Settings.Default.DBUser,
                Password = Settings.Default.DBPass,
                MinimumPoolSize = Settings.Default.DBMinPoolSize,
                MaximumPoolSize = Settings.Default.DBMaxPoolSize,
                ConnectionTimeout = 1
            };

            ISessionFactory isessionFactory = Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard.ConnectionString(
                        c => c.Is(rawConnectionString: connectionStringBuilder.ConnectionString)
                    )
                )
                .Cache(c => c
                    .UseQueryCache()
                    .ProviderClass<HashtableCacheProvider>()
                )
                .ExposeConfiguration(x => {
                    x.SetInterceptor(new SqlStatementInterceptor());
                }
                )
                .Mappings(m => {
                    m.FluentMappings.AddFromAssemblyOf<AccountMap>();
                }
                )
                .BuildSessionFactory();

            return isessionFactory;
        }
    }
}
