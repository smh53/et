using et.dal.Abstract;
using et.dal.Concrete.EntityFramework;
using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.bl.Concrete
{
    public class FirmWithAuthService : FirmService
    {
        public FirmWithAuthService(IRepository<FirmEntity> repository) : base(repository)
        {
        }

        public override int Create(FirmEntity entity)
        {
            if(entity.Code.EndsWith("_yetliki"))
                return base.Create(entity);

            return 0; 
        }
    }
}
