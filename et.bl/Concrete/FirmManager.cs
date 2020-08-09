using et.bl.Abstract;
using et.dal.Abstracts;
using et.documents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace et.bl.Concrete
{
    public class FirmManager : IFirmService
    {
        private IFirmRepo _firmRepo;

        public FirmManager(IFirmRepo firmRepo)
        {
            _firmRepo = firmRepo;
        }
        public void Create(FirmEntity entity)
        {
            _firmRepo.Create(entity);
        }

        public void Delete(FirmEntity entity)
        {
            _firmRepo.Delete(entity);
        }

        public List<FirmEntity> GetAll()
        {
            return _firmRepo.GetAll();
        }

        public FirmEntity GetById(int id)
        {
            return _firmRepo.GetById(id);
        }

        public void Update(FirmEntity entity)
        {
            _firmRepo.Update(entity);
        }
    }
}
