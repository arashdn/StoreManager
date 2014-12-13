using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class Accounting
    {
        //sabt , hazf , edit check va sabt,hazf,edit hazine , mostaghiman az interface barname be dbcontext dade mishavad
        public void sabteBedehi(long price , DateTime date , bool isPersoanl , Transaction.PaymentTypes type , DateTime? deadline = null , Check chk = null , Contact cnt = null )
        {
            DBContext myDB = new DBContext();////We need this to use function - association
        }
        public void sabteTalab(long price, DateTime date, bool isPersoanl, Transaction.PaymentTypes type, DateTime? deadline = null, Check chk = null, Contact cnt = null)
        {
            DBContext myDB = new DBContext();////We need this to use function - association
        }
        public void pardakhteBedehi(FinancialTransaction ft)
        {
            DBContext myDB = new DBContext();////We need this to use function - association
        }
        public void pardakhteTalab(FinancialTransaction ft)
        {
            DBContext myDB = new DBContext();////We need this to use function - association
        }
        public void vosoolCheck(Check chk)
        {
            DBContext myDB = new DBContext();////We need this to use function - association
        }
    }
}
