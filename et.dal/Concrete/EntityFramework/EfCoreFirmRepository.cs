using et.dal.Abstracts;
using et.dal.Concrete.Context;
using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.dal.Concrete.EntityFramework
{
    public class EfCoreFirmRepository : EfCoreGenericRepository<FirmEntity, EtContext>, IFirmRepo
    {
       
    }
}
