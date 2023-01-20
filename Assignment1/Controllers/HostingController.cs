using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingController : ApiController
    {
        // Output 3 strings which describe the total hosting cost
        // Hosting 0 day with 3 output strings which descsribe the total hosting cost
        // Hosting 14 days with 3 output strings which descsribe the total hosting cost
        // Hosting 15 days with 3 output strings which descsribe the total hosting cost
        // Hosting 21 days with 3 output strings which descsribe the total hosting cost
        // Hosting 28 days with 3 output strings which descsribe the total hosting cost

        public string Get(int id)
        {
            var FN = 0;
            if (id < 14)
            {
                FN = 1;
            }
            else if (id >= 14 && id < 28)
            {
                FN = 2;
            }
            else if (id >= 28)
            {
                 FN = 3;
            }

             double cost = (FN * 5.50);
             double tax = (cost * 0.13);
             double TotalCost = cost + tax;
            string Message =  FN + " fortnight at $5.50/FN = $" + Math.Round(cost, 2) + " CAD " + "HST 13% = $" + Math.Round(tax, 2) + " CAD " + "Total = $" + Math.Round(TotalCost, 2) + " CAD ";
            return Message;
        } 
    }
}
