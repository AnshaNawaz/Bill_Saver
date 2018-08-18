using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBill_Server.DAL;

namespace EBill_Server.BAL
{
    public class BillBO
    {
        public static int createNewBill(int createdBy)
        {
            return EBill_Server.DAL.BillDAO.createNewBill(createdBy);
        }
    }
}
