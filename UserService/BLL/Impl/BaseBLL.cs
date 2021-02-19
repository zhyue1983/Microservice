using UserService.DAL;
using UserService.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace UserService.BLL.Impl
{
    public class BaseBLL : IBaseBLL
    {

        private readonly IBaseDAL _baseDAL;
        public BaseBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }


        #region 查询
        public List<T> GetList<T>() where T : BaseEntity
        {
            return _baseDAL.GetList<T>();
        }

        public List<T> GetList<T>(int top) where T : BaseEntity
        {
            return _baseDAL.GetList<T>(top);
        }
        public T Get<T>(int id) where T : BaseEntity
        {
            return _baseDAL.Get<T>(id);
        }
        #endregion

        public int Insert<T>(T t) where T : BaseEntity
        {
            return _baseDAL.Insert(t);
        }
        public int Update<T>(T t) where T : BaseEntity
        {
            return _baseDAL.Update(t);
        }

        public int Delete<T>(int id) where T : BaseEntity
        {
            return _baseDAL.Delete<T>(id);
        }

        public List<T> GetList<T>(Expression<Func<T, bool>> where) where T : BaseEntity
        {
            return _baseDAL.GetList(where);
        }

        public IQueryable<T> GetIQueryable<T>() where T : BaseEntity
        {
            return _baseDAL.GetIQueryable<T>();
        }
    }
}
