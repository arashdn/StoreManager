using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class ProductTransactionItem
    {
        private long buyerPrice;
        private int code;
        private int count;
        private long itemDiscount;
        private long itemPrice;
        private Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        
        public long ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        
        public long ItemDiscount
        {
            get { return itemDiscount; }
            set { itemDiscount = value; }
        }
        
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

	    public int Code
	    {
	       	get { return code;}
		    set { code = value;}
	    }
        public long BuyerPrice
        {
            get { return buyerPrice; }
            set { buyerPrice = value; }
        }
        public long TotalDiscount
        {
            get { return itemDiscount * count; }
        }
        public long TotalPrice
        {
            get { return itemPrice * count; }
        }
        public long TotalPriceAfterDiscount
        {
            get { return TotalPrice - TotalDiscount; }
        }
    }
}
