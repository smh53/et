using et.dal.Abstract;
using et.dal.Concrete.Context;
using et.documents.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace et.dal.Concrete.EntityFramework
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly EtContext _dbContext;

        public EfCoreGenericRepository(EtContext dbContext)

        {
            _dbContext = dbContext;
        }
        public int Create(TEntity entity)
        {
            return _dbContext.Set<TEntity>().Add(entity).Entity.Id;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public IList<TEntity> GetList()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
