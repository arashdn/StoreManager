using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class Report
    {
        //ham bedehi ham talab
        public void getBedehiReport(DateTime startDate , DateTime endDate)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            List<FinancialTransaction> lst;//needed for report  - association
        }

        public void getBuyReport(DateTime startDate, DateTime endDate)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            List<ProductTransaction> lst;//needed for report  - association
        }

        public void getCheckReport(DateTime startDate, DateTime endDate)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            List<Check> lst;//needed for report  - association
        }

        public void getSellReport(DateTime startDate, DateTime endDate)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            List<ProductTransaction> lst;//needed for report  - association
        }

        public void getMoneyReport(DateTime startDate, DateTime endDate)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            List<ProductTransaction> lst;
            List<FinancialTransaction> lst2;
            List<MoneyTransaction> lst3;
        }
    }
}
