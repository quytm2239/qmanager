using NHibernate;
using QManager.DB;
using QManager.Model;
using System;
using System.Collections.Generic;

namespace QManager.DAO
{
    public class BaseDAO
    {
        public static readonly ISessionFactory SessionFactory = FluentNHibernateConnection.CreateSessionFactory();
        public static ISession GetSession() => SessionFactory.OpenSession();

        public static BaseModel Add(BaseModel obj)
        {
            using (var session = GetSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(obj);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            return obj;
        }

        public static BaseModel Update(BaseModel obj)
        {
            using (var session = GetSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(obj);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            return obj;
        }

        public static BaseModel Delete(BaseModel obj)
        {
            using (var session = GetSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(obj);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            return obj;
        }
    }
}
