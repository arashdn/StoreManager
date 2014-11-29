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
        private Data creationData;
        private int paymentData;
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
        
        public int PaymentData
        {
            get { return paymentData; }
            set { paymentData = value; }
        }
        
        public Data CreationData
        {
            get { return creationData; }
            set { creationData = value; }
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
