using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApiTest.DB;
using WepApiTest.Methots.InterFace;

namespace WepApiTest.UnitOfWork
{
   public interface IUnitOfWork :IDisposable
    {
        IBase<T> GetBase<T>() where T : class;
        int Save();
        ApiContext Ctx();
    }
}
