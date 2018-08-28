using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    [EnableCorsAttribute("*", "*", "*")]
    public class LoginController : ApiController
    {

        [HttpPost]
        [Route("authenticate")]
        public LoginResponse Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //TODO: Validate credentials Correctly, this code is only for demo !!
            bool isCredentialValid = (login.Password == "123456");
            if (isCredentialValid)
            {
                LoginResponse resp = new LoginResponse();
                string token = TokenGenerator.GenerateTokenJwt(login.Nombre);
                resp.token = token;
                resp.nombre = login.Nombre;

                return resp;
            }
            else
            {
                LoginResponse resp = new LoginResponse();
                resp.token = "";
                return resp;
            }
        }
    }
}
