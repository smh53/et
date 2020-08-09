using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using et.api.Models;
using et.bl.Abstract;
using et.documents.Entities;
using Microsoft.AspNetCore.Mvc;

namespace et.api.Controllers
{
    abstract public class AbstractController<TRequest, TResponse, TService, TEntity> : Controller
         where TEntity : BaseEntity
        where TRequest : BaseRequestModel<TEntity>
        where TResponse : BaseResponseModel<TEntity>
        where TService : IBaseService<TEntity>
    {
        private readonly TService _service;

        public AbstractController(TService service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual ActionResult<IList<TEntity>> Get()
        {
            TResponse response = Activator.CreateInstance<TResponse>();
            response.EntityList = _service.GetList();
            return Json(response);
        }
        [HttpGet("{id}")]
        public virtual ActionResult<IList<TEntity>> Get(int id)
        {
            TResponse response = Activator.CreateInstance<TResponse>();
            response.Entity = _service.Get(id);
            return Json(response);
        }
        [HttpPost]
        public virtual ActionResult<TResponse> Post(TRequest request)
        {
            TResponse response = Activator.CreateInstance<TResponse>();

            bool isSuccess = false;

            if (request == null || request.Entity == null)
            {
                response.AddMessage("model boş", isSuccessMessage: isSuccess);
            }
            else
            {
                if (request.Entity.Id == 0)
                {
                    _service.Create(request.Entity);
                    isSuccess = true;
                }
                else
                {
                    var entity = _service.Get(request.Entity.Id);
                    if (entity == null)
                    {
                        response.AddMessage("veri bulunamadı", isSuccessMessage: isSuccess);
                    }
                    else
                    {
                        _service.Update(request.Entity);
                        isSuccess = true;
                    }
                }
            }

            return Json(isSuccess);
        }

    }
}
