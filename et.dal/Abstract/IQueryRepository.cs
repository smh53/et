using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Abstract
{
  public interface IQueryRepository<T>
    {
        IList<T> GetList();
        T Get(int id);
    }
}
