using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Transaction
    {
        private int paymentType;
        private int code;
        private Contact contact;
        private DateTime creationDate;
        private int paymentDate;
        private long totalPrice;
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public long TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        
        public int PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        
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
        
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        
    }
}
