using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.bl.Abstract
{
   public interface IFirmService
    {
        void Create(FirmEntity entity);
        void Update(FirmEntity entity);
        void Delete(FirmEntity entity);

        FirmEntity GetById(int id);
        List<FirmEntity> GetAll();
    }
}
