using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SmartFarmer.AuthFilter
{
    public class CustomerL : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;            
            if (token != null)
            {
                var tk = AuthService.RetTok(token.ToString());
                var user = UserService.Get(tk.UserId);
                if(user.Type != "Customer" || tk.UserId != user.Id)
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "Not a Customer user");
                }
                
            }
            base.OnAuthorization(actionContext);
        }
    }
}