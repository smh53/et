using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Abstract
{
   public interface IDeleteRepository<T>
    {
        void Delete(T entity);

    }
}
