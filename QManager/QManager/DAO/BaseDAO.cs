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
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    try {
                        session.Save(obj);
                        transaction.Commit();
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
            return obj;
        }

        public static List<BaseModel> DoAddTransaction(List<BaseModel> objList)
        {
            List<BaseModel> resultList = new List<BaseModel>();
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    for (int i = 0; i < objList.Count; i++) {
                        BaseModel obj = objList[i];
                        try {
                            session.Save(obj);
                            resultList.Add(obj);
                            if (i == objList.Count - 1) transaction.Commit();
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            transaction.Rollback();
                            return null;
                        }
                    }
                }
            }
            return resultList;
        }

        public static BaseModel Update(BaseModel obj)
        {
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    try {
                        session.Update(obj);
                        transaction.Commit();
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
            return obj;
        }

        public static List<BaseModel> DoUpdateTransaction(List<BaseModel> objList)
        {
            List<BaseModel> resultList = new List<BaseModel>();
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    for (int i = 0; i < objList.Count; i++) {
                        BaseModel obj = objList[i];
                        try {
                            session.Update(obj);
                            resultList.Add(obj);
                            if (i == objList.Count - 1) transaction.Commit();
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            transaction.Rollback();
                            return null;
                        }
                    }
                }
            }
            return resultList;
        }

        public static BaseModel Delete(BaseModel obj)
        {
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    try {
                        session.Delete(obj);
                        transaction.Commit();
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
            return obj;
        }

        public static List<BaseModel> DoDeleteTransaction(List<BaseModel> objList)
        {
            List<BaseModel> resultList = new List<BaseModel>();
            using (var session = GetSession()) {
                using (ITransaction transaction = session.BeginTransaction()) {
                    for (int i = 0; i < objList.Count; i++) {
                        BaseModel obj = objList[i];
                        try {
                            session.Delete(obj);
                            resultList.Add(obj);
                            if (i == objList.Count - 1) transaction.Commit();
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            transaction.Rollback();
                            return null;
                        }
                    }
                }
            }
            return resultList;
        }
    }
}
