using UserService.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
using Common;

namespace UserService.DAL.Impl
{
    public class BaseDAL : IBaseDAL
    {
        #region 查询
        public List<T> GetList<T>() where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {
                return client.Set<T>().ToList();
            }
        }

        public List<T> GetList<T>(int top) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {
                return client.Set<T>().Take(top).ToList();
            }
        }
        public List<T> GetList<T>(Expression<Func<T, bool>> where) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {
                return client.Set<T>().Where(where).ToList();
            }
        }
        public IQueryable<T> GetIQueryable<T>() where T : BaseEntity
        {
            var client = new UserServiceContext();
            return client.Set<T>();
        }
        public T Get<T>(int id) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {

                return client.Set<T>().Find(id);
            }
        }
        #endregion

        public int Insert<T>(T t) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {

                T entity = client.Set<T>().Add(t).Entity;

                client.SaveChanges();
                PropertyInfo p = entity.GetType().GetProperty("Id");
                int res = p.GetValue(entity).ToString().ToIntByStr();

                return res;
            }
        }
        public int Update<T>(T t) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {

                client.Set<T>().Update(t);

                int res = client.SaveChanges();
                return res;
            }
        }

        public int Delete<T>(int id) where T : BaseEntity
        {
            using (var client = new UserServiceContext())
            {
                T t = Get<T>(id);

                client.Set<T>().Remove(t);

                int res = client.SaveChanges();
                return res;
            }
        }
    }
}
