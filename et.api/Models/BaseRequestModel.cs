using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace et.api.Models
{
    public class BaseRequestModel<TEntity> : BaseTransferModel<TEntity>
        where TEntity: BaseEntity
    {

    }
}
