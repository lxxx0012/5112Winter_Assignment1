using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        // Find the square of the input integer
        // Find the square of the input integer of 2 -> 4
        // Find the square of the input integer of -2 -> 4
        // Find the square of the input integer of 10 -> 100

        public int Get(int id)
        {
            int value = (int)Math.Pow(id , 2);
            //int value = id * id;
            return value;
        }
    }
}
