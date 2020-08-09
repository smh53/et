using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace et.api.Models
{
    public class BaseResponseModel<TEntity> : BaseTransferModel<TEntity>
        where TEntity : BaseEntity
    {
        public bool IsSuccess { get; set; } = true;
        public IList<string> Messages { get; set; }

        public void AddMessage(string message, bool isSuccessMessage=true)
        {
            if (Messages == null)
               Messages = new List<string>();
            
            IsSuccess = isSuccessMessage;
            Messages.Add(message);
        }
    }
}
