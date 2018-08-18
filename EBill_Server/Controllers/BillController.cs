using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EBill_Server.Entities;
using EBill_Server.BAL;

namespace EBill_Server.Controllers
{
    public class BillController : ApiController
    {
        [HttpGet]
        public  int createNewBill(int createdBy)
        {
            return EBill_Server.BAL.BillBO.createNewBill(createdBy);
        }
    }
}
