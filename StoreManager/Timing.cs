using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class Timing
    {
        public List<MoneyTransaction> getDayBedehi(DateTime date)
        {
            DBContext myDB = new DBContext();//We need this to use function - association
            return null;
        }

        public List<MoneyTransaction> getTodayBedehi()
        {
            return getDayBedehi(DateTime.Now);
        }
    }
}
