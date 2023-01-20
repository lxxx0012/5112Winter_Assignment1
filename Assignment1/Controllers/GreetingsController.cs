using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingsController : ApiController
    {
        // Return the string "Greeting to {id} people!"
        // Retrun the greeting with an integer value of 3 -> "Greeting to 3 people!"
        // Retrun the greeting with an integer value of 6 -> "Greeting to 3 people!"
        // Retrun the greeting with an integer value of 0 -> "Greeting to 3 people!"

        public string Get(int id)
        {
            string Message = "Greeting to " + id + " people!";
            return Message;
        }
    }
}
