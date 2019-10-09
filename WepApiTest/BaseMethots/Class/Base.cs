using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiTest.DB;
using WepApiTest.Methots.InterFace;
using WepApiTest.Models.DbModels;

namespace WepApiTest.Methots
{
    public class Base<T> : IBase<T> where T : class
    {
        protected ApiContext DbContext;
        private DbSet<T> Db;
        public Base(ApiContext _DbContext)
        {
            DbContext = _DbContext;
            Db = DbContext.Set<T>();
        }

        #region getAll 
        public IQueryable<T> GetAll(params string[] includes)
        {
            if (includes.Length <= 0) return Db;

            foreach (var include in includes)
            {
                Db.Include(include).Load();
            }
            return Db;
        }
        #endregion

        #region GetById

        public T GetById(int? id, params string[] includes)
        {
            if (includes.Length <= 0) return Db.Find(id);

            foreach (var include in includes)
            {
                Db.Include(include).Load();//????
            }
            var element = Db.Find(id);
            return element;
        }

        #endregion

        #region AddPost
        public void Add(T entity,params string[] includes)
        {
            if (includes.Length <= 0)
            {
                Db.AddAsync(entity);
            }

            foreach (var include in includes)
            {
                Db.Include(include).Load();
            }
            Db.AddAsync(entity);
        }

        #endregion

        #region Edite
        public T Update(T entity)
        {
            DbContext.Entry(entity).CurrentValues.SetValues(entity);
            DbContext.SaveChanges();
            return entity;
        }
        #endregion

        #region Delete
        public void Remove(T Entity)
        {
            Db.Remove(Entity);
            DbContext.SaveChanges();
        }
      
        #endregion
    }
}
