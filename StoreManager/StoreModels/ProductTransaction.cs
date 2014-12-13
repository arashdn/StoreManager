using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class ProductTransaction:Transaction
    {

        //Also creates one to many releation in EF
        //virtual is for lazy loading
        [System.ComponentModel.DataAnnotations.Required]
        public virtual List<ProductTransactionItem> items { get; set; }


        #region ReadOnly Properties
        public long TotalDiscount
        {
            get 
            {
                long sum = 0;
                foreach (ProductTransactionItem item in items)
                    sum += item.TotalDiscount;
                return sum;
            }
        }
        public long TotalPrice
        {
            get 
            {
                long sum = 0;
                foreach (ProductTransactionItem item in items)
                    sum += item.TotalPrice;
                return sum;
            }
        }
        public long PriceAfterDiscount
        {
            get 
            { 
                return TotalPrice - TotalDiscount; 
            }
        }
        #endregion
    }
}
