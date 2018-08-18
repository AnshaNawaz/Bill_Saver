using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBill_Server.Entities
{
    public class UserDTO
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public bool isAdmin { get; set; }
    }
}