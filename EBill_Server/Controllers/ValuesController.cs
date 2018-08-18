using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace EBill_Server.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public int getValue()
        {
            return 10;
        }
    }
}