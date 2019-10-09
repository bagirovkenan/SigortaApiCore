using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiTest.DB;
using WepApiTest.Methots.InterFace;
using WepApiTest.Models.DbModels;
using WepApiTest.UnitOfWork;

namespace WepApiTest.Methots.General
{
    public class UnitOfWorkClass : IUnitOfWork
    {
        protected ApiContext DbContext;
        
        public UnitOfWorkClass(ApiContext _DbContext)
        {
            DbContext = _DbContext;         
        }
      


        public int Save()
        {
           return DbContext.SaveChanges();           
        }
        public void Dispose()
        {
            DbContext.Dispose();
        }

        public IBase<T> GetBase<T>() where T : class
        {
            return new Base<T>(DbContext);
        }

        public ApiContext Ctx()
        {
            return DbContext;
        } 
    }
}
