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

    public class FarmerController : ApiController
    {

        [Route("api/Farmer")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = FarmerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Farmer/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = FarmerService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Farmer")]
        public HttpResponseMessage Add(FarmerDTO Farmer)
        {
            var data = FarmerService.AddFarmer(Farmer);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/Farmer/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = FarmerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Farmer")]
        [HttpPatch]
        public HttpResponseMessage Update(FarmerDTO obj)
        {
            var data = FarmerService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
