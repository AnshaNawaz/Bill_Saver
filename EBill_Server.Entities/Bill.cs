﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBill_Server.Entities
{
    public class Bill
    {
        public int ID { get; set; }
        public int createdBy { get; set; }
        public DateTime createdOn { get; set; }
        public int Price { get; set; }
    }
}