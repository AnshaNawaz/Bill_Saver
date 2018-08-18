using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBill_Server.DAL
{
    public class Eqp_AttrDAO
    {
        public static bool enterNewItemInBill(int Bill_ID,String Equipment_ID,int Equipment_Quantity)
        {

            String query = "Insert  into Eqp_Attr(Bill_ID,Equipment_ID,Equipment_Quantity) values(" + Bill_ID + ",'" + Equipment_ID + "'," + Equipment_Quantity + ")";
            using(DBHelper helper=new DBHelper())
            {
                int a = helper.ExecuteQuery(query);
                if (a > 0)
                    return true;
            }

            return false;
        }
    }
}
