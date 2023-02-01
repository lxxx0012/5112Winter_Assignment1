using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        // Return 10 more than the input integer
        // Return an integer of 21 -> 31
        // Return an integer of 0 -> 10
        // Return an integer of -9 -> 1
        //test


        public int Get(int id)
        {
            int value = id + 10;
            return value;
        }
    }
}
