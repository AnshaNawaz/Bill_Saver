using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBill_Server.BAL
{
    public class Eqp_AttrBO
    {
        public static bool enterNewItemInBill(int Bill_ID,String Equipment_ID,int Equipment_Quantity)
        {
            return EBill_Server.DAL.Eqp_AttrDAO.enterNewItemInBill(Bill_ID, Equipment_ID, Equipment_Quantity);
        }
    }
}
