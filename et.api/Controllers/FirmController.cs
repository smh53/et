using et.api.Models;
using et.bl.Abstract;
using et.bl.Concrete;
using et.documents.Entities;
using Microsoft.AspNetCore.Mvc;

namespace et.api.Controllers
{
    [Route("/firm")]
    [ApiController]
    public class FirmController : AbstractController<BaseRequestModel<FirmEntity>,BaseResponseModel<FirmEntity>, IFirmService, FirmEntity>
    {

        public FirmController(IFirmService service) : base(service)
        {
        }

        public override ActionResult<BaseResponseModel<FirmEntity>> Post(BaseRequestModel<FirmEntity> request)
        {

            a.Create();

            return base.Post(request);
        }
    }
}
