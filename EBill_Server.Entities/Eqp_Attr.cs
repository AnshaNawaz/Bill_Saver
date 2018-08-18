using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace EBill_Server.Entities
{
    public class Eqp_Attr
    {
        public int ID { get; set; }
        public int Bill_ID { get; set; }
        public int Equipment_ID { get; set; }
        public int Equipment_Quantity { get; set; }
    }

}