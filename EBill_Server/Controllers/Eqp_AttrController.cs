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
    public class Eqp_AttrController : ApiController
    {
        [HttpGet]
        public bool enterNewItemInBill(int Bill_ID,String Equipment_ID,int Equipment_Quantity)
        {
            return EBill_Server.BAL.Eqp_AttrBO.enterNewItemInBill(Bill_ID, Equipment_ID, Equipment_Quantity);
        }

    }
}
