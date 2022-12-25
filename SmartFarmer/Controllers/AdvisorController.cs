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
    public class AdvisorController : ApiController
    {
        [Route("api/advisors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdvisorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdvisorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors")]
        [HttpPost]
        public HttpResponseMessage Add(AdvisorDTO advisor)
        {
            var data = AdvisorService.Add(advisor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors")]
        [HttpPatch]
        public HttpResponseMessage Update(AdvisorDTO obj)
        {
            var data = AdvisorService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/advisors/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdvisorService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
