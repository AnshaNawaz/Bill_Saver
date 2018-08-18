using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBill_Server.DAL
{
    public class BillDAO
    {
        public static int createNewBill(int createdBy)
        {
            DateTime d = DateTime.Now;
            String query = "Insert into Bill(createdBy,createdOn) values('" + createdBy + "','" + d + "')";
            String query1 =  "Select max(ID) from Bill";
            using(DBHelper helper=new DBHelper())
            {
                int a = helper.ExecuteQuery(query);
                if(a>0)
                {
                    helper.Dispose();
                    using (DBHelper helper1=new DBHelper())
                    {
                        int id=Convert.ToInt32(helper1.ExecuteScalar(query1));
                        return id;
                    }
                }
            }
            return 0;
        }
    }
}
