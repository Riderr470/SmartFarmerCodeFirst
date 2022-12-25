using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SmartFarmer.Controllers
{
    [EnableCors("*", "*", "*")]

    public class ProductController : ApiController
    {
        [Route("api/Product")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ProductService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Product/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = ProductService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/Product/add")]
        public HttpResponseMessage Add(ProductDto product)
        {
            var data = ProductService.AddProduct(product);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/Product/Delete/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = ProductService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPatch]
        [Route("api/Product/Update")]
        public HttpResponseMessage Update(ProductDto obj)
        {
            var data = ProductService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}