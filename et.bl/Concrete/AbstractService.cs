using et.bl.Abstract;
using et.dal.Abstract;
using et.documents.Entities;
using System.Collections.Generic;

namespace et.bl.Concrete
{
    public abstract class AbstractService<TEntity> : IBaseService<TEntity>
        where TEntity: BaseEntity
    {
        private readonly IRepository<TEntity> _repository;
        public AbstractService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual int Create(TEntity entity)
        {
            return _repository.Create(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IList<TEntity> GetList()
        {
            return _repository.GetList();
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

    }
}
