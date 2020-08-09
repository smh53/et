using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Abstracts
{
  public  interface IRepo<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetById(int id);
        List<T> GetAll();


    }
}
