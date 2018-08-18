using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBill_Server.Entities;
using System.Data.SqlClient;
namespace EBill_Server.DAL
{
    public class UserDAO
    {
        public static bool saveNewUser(String Name,String Login,String Password,bool isAdmin)
        {
            String isAdminBit=" ";
            if(isAdmin==true)
            {
                isAdminBit="1";
            }
            else
            {
                isAdminBit="0";
            }
            String query = String.Format("insert into [User](Name,Login,Password,isAdmin)  values('{0}','{1}','{2}','{3}')", Name, Login, Password, isAdminBit); 
            using (DBHelper helper = new DBHelper())
            {
                int a = helper.ExecuteQuery(query);
                if (a > 0)
                    return true;
            }
            return false;
        }
        public static int userLogin(String Login,String Password)
        {
            String query="select * from [User] where Login='"+Login+"'And Password='"+Password+"'";
            using (DBHelper helper=new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(query);
                if(reader.Read())
                {
                    if(reader.GetString(reader.GetOrdinal("isAdmin"))=="0")
                        return Convert.ToInt32(reader.GetString(reader.GetOrdinal("ID")));
                }
            }
            return 0;
        }
        public static int adminLogin(String Login, String Password)
        {
            String query = "select * from [User] where Login='" + Login + "'And Password='" + Password + "'";
            using (DBHelper helper = new DBHelper())
            {
                SqlDataReader reader = helper.ExecuteReader(query);
                if (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("isAdmin")) == "1")
                        return Convert.ToInt32(reader.GetString(reader.GetOrdinal("ID")));
                }
            }
            return 0;
        }

        public static UserDTO fillDTO(SqlDataReader reader)
        {
            UserDTO u = new UserDTO();
            u.Name = reader.GetString(reader.GetOrdinal("Name"));
            u.Login = reader.GetString(reader.GetOrdinal("Login"));
            u.Password = reader.GetString(reader.GetOrdinal("Password"));
            u.isAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
            return u;
        }
    }
}
