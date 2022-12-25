using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SmartFarmer.Controllers
{
    [EnableCors("*", "*", "*")]

    public class EquipmentController : ApiController
    {
        [Route("api/Equipment")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = EquipmentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Equipment/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = EquipmentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Equipment")]
        public HttpResponseMessage Add(EquipmentDTO Equipment)
        {
            var data = EquipmentService.AddEquipment(Equipment);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/Equipment/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = EquipmentService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Equipment")]
        [HttpPatch]
        public HttpResponseMessage Update(EquipmentDTO obj)
        {
            var data = EquipmentService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}

