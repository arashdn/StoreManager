using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class MoneyTransaction:Transaction
    {
        private int isPersonal;

        public int IsPersonal
        {
            get { return isPersonal; }
            set { isPersonal = value; }
        }
        
    }
}
