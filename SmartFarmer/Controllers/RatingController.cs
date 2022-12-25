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

    public class RatingController : ApiController
    {
        [Route("api/Rating")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RatingService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Rating/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = RatingService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Rating/add")]
        public HttpResponseMessage Add(RatingDto rating)
        {
            var data = RatingService.AddRating(rating);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpDelete]
        [Route("api/Rating/Delete/{id}")]

        public HttpResponseMessage Remove(int id)
        {
            var data = RatingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Rating/Update")]
        [HttpPatch]
        public HttpResponseMessage Update(RatingDto obj)
        {
            var data = RatingService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}