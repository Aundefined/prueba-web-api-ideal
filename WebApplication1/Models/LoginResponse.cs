using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Models
{
    public class LoginResponse
    {
        public string token { get; set; }
        public string nombre { get; set; }
    }
}