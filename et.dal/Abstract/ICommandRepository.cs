using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Abstract
{
   public interface ICommandRepository<T>
    {
        int Create(T entity);
        void Update(T entity);
    }
}
