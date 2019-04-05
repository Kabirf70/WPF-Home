using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Home.Controllers
{
    public class HomeController : ApiController
    {
        private static List<string> city = new List<string> { "dhaka", "Mymensingh", "bogra" };

        public IEnumerable<string> Get()
        {
            return city;
        }
        public string Get(int id)
        {
            return city[id];
        }
    }
}
