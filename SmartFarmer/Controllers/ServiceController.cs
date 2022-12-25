
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SmartFarm.Controllers
{
    [EnableCors("*", "*", "*")]

    public class ServiceController : ApiController
    {
        [Route("api/Service")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ServiceService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Service/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = ServiceService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Service/add")]
        public HttpResponseMessage Add(ServiceDto service)
        {
            var data = ServiceService.AddService(service);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}