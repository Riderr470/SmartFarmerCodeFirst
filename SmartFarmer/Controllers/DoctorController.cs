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

    public class DoctorController : ApiController
    {
        [Route("api/Doctor")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DoctorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Doctor/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = DoctorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Doctor/add")]
        public HttpResponseMessage Add(DoctorDto doctor)
        {
            var data = DoctorService.AddDoctor(doctor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }

}