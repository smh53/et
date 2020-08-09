using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Abstract
{
   public interface IRepository<TEntity> : ICommandRepository<TEntity>, IQueryRepository<TEntity>,IDeleteRepository<TEntity>
        where TEntity: BaseEntity
    {
        //int Create(TEntity entity);
        //void Update(TEntity entity);

        //void Delete(TEntity entity);

        //IList<TEntity> GetList();
        //TEntity Get(int id);

    }
}
