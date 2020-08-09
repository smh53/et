using et.bl.Abstract;
using et.dal.Abstract;
using et.documents.Entities;

namespace et.bl.Concrete
{
    public class FirmService : AbstractService<FirmEntity>, IFirmService
    {
        public FirmService(IRepository<FirmEntity> repository) : base(repository)
        {

        }

    }
}

