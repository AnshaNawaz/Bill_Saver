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
    public class UserController : ApiController
    {
        [HttpGet]
        public bool saveNewUser(String Name,String Login,String Password,bool isAdmin)
        {
            return EBill_Server.BAL.UserBO.saveNewUser(Name,Login,Password,isAdmin);
        }
        [HttpGet]
        public int adminLogin(String Login, String Password)
        { 
            return EBill_Server.BAL.UserBO.adminLogin(Login, Password);
        }
        [HttpGet]
        public int userLogin(String Login, String Password)
        {
            return EBill_Server.BAL.UserBO.userLogin(Login, Password);
        }
    }
}
