using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Check
    {
        private string bankBranch;
        private string checkNumber;
        private int code;
        private long price;
        private int vosoolStatus;

        public int VosoolStatus
        {
            get { return vosoolStatus; }
            set { vosoolStatus = value; }
        }
        
        public long Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        
        public string CheckNumber
        {
            get { return checkNumber; }
            set { checkNumber = value; }
        }

        public string BankBranch
        {
            get { return bankBranch; }
            set { bankBranch = value; }
        }

    }
}
