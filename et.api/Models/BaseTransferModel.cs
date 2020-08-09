using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace et.api.Models
{
    public class BaseTransferModel<TEntity>
        where TEntity: BaseEntity
    {
        public TEntity Entity { get; set; }
        public IList<TEntity> EntityList { get; set; }
    }
}
