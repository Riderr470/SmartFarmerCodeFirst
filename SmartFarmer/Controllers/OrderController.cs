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

    public class OrderController : ApiController
    {
        [Route("api/orders")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = OrderService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = OrderService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders")]
        [HttpPost]
        public HttpResponseMessage Add(OrderDTO advisor)
        {
            var data = OrderService.Add(advisor);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders")]
        [HttpPatch]
        public HttpResponseMessage Update(OrderDTO obj)
        {
            var data = OrderService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/orders/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var data = OrderService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
