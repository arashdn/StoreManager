using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Transaction
    {


        public enum PaymentTypes //estefade shode dar class haye inherit shode
        {
            Naghd = 1,
            Check,
            Variz,
            Other
        }


        private int code;
        private Contact contact;//aggregation
        private Check check;//aggregation
        private DateTime creationDate;
        private DateTime? paymentDate;
        private long totalPrice;
        private string note;


        public Check Check
        {
            get { return check; }
            set { check = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public long TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public DateTime? PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        
        public Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }


        [System.ComponentModel.DataAnnotations.Key]
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public PersianDateTime PersianCreationDateDate
        {
            get { return new PersianDateTime(creationDate); }
        }

        public PersianDateTime PersianPaymentDate
        {
            get { return new PersianDateTime((DateTime)paymentDate); }
        }
        
    }
}
