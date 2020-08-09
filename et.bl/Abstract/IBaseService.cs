using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.bl.Abstract
{
   public interface IBaseService<TEntity>
        where TEntity: BaseEntity
    {
        int Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(int id);
        IList<TEntity> GetList();
    }
}
