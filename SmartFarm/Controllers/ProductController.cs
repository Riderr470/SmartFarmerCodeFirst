using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFarm.Controllers
{
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
    }
}