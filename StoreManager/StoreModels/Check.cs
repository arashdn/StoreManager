using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Check
    {

        public enum VosoolStatuses
        {
            vosoolShode = 1,
            pishAzMoed,
            bargashti
        }

        private string bankBranch;
        private string checkNumber;
        private int code;
        private long price;
        private VosoolStatuses vosoolStatus;
        private DateTime date;


        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }




        public PersianDateTime PersianDate
        {
            get { return new PersianDateTime(Date); }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public VosoolStatuses VosoolStatus
        {
            get { return vosoolStatus; }
            set { vosoolStatus = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public long Price
        {
            get { return price; }
            set { price = value; }
        }
        
        [System.ComponentModel.DataAnnotations.Key]
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
