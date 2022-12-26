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

    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(UserDto login)
        {
            var token = AuthService.Authenticate(login.Email, login.Password, login.Id);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Usernot found");

        }
        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            var log = AuthService.deleteToken(token);
            if(log)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Logged out");
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "log out failed");

        }

    }
}
