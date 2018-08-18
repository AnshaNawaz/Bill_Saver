using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBill_Server.DAL;

namespace EBill_Server.BAL
{
    public class UserBO
    {
        public static bool saveNewUser(String Name,String Login,String Password,bool isAdmin)
        {
            return EBill_Server.DAL.UserDAO.saveNewUser(Name, Login, Password, isAdmin);
        }
        public static int adminLogin(String Login, String Password)
        {
            return EBill_Server.DAL.UserDAO.adminLogin(Login, Password);
        }
        public static int userLogin(String Login, String Password)
        {
            return EBill_Server.DAL.UserDAO.userLogin(Login, Password);
        }
    }
}
