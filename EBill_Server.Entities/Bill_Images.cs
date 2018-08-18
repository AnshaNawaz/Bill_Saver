using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBill_Server.Entities
{
    public class Bill_Images
    {
        public int ID { get; set; }
        public int Bill_ID { get; set; }
        public String Image_Url { get; set; }
    }
}