using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // Return the string of "Hello World!"
        public string Get()
        {
            string Message = "Hello World!";
            return Message;
        }
    }
}
