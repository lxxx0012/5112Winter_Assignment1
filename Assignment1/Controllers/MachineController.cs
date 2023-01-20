using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class MachineController : ApiController
    {
        // Create a method with an integer and applies 4 mathematical operations to it
        // Create a method with an integer of 10 -> ?
        // Create a method with an integer of -5 -> ?
        // Create a method with an integer of 30 -> ?

        public int Get(int id)
        {
            int value = id * 10 / 4 + 8 - 3;
            return value;
        }
    }
}
