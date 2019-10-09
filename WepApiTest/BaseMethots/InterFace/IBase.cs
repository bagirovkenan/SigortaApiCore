using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApiTest.Methots.InterFace
{
    public interface IBase<I> where I : class
    {
        IQueryable<I> GetAll(params string[] list);

        I GetById(int? id, params string[] list);

        void Add(I entity, params string[] list);  //??

        I Update(I entity);

        void Remove(I entity);

      
    }
}
