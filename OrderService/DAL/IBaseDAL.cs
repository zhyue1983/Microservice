using OrderService.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace OrderService.DAL
{
    public interface IBaseDAL
    {


        List<T> GetList<T>(int top) where T : BaseEntity;
        List<T> GetList<T>() where T : BaseEntity;

        List<T> GetList<T>(Expression<Func<T, bool>> where) where T : BaseEntity;
        IQueryable<T> GetIQueryable<T>() where T : BaseEntity;

        int Insert<T>(T t) where T : BaseEntity;
        int Update<T>(T t) where T : BaseEntity;

        T Get<T>(int id) where T : BaseEntity;
        int Delete<T>(int id) where T : BaseEntity;
    }
}
