﻿using System;
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
        public List<ProductTransaction> getDayPayments(DateTime date)
        {
            DBContext myDB = new DBContext();
            return null;
        }
        public List<ProductTransaction> getTodayPayments()
        {
            return getDayPayments(DateTime.Now);
        }
        public List<MoneyTransaction> getDayTalab(DateTime date)
        {
            DBContext myDB = new DBContext();
            return null;
        }
        public List<MoneyTransaction> getTodayTalab()
        {
            return getDayTalab(DateTime.Now);
        }
        public List<Check> getDayChecks(DateTime date)
        {
            DBContext myDB = new DBContext();
            return null;
        }
        public List<Check> getTodayChecks()
        {
            return getDayChecks(DateTime.Now);
        }
    }
}