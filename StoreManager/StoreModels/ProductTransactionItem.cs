using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class ProductTransactionItem
    {
        private long? buyerPrice;
        private int code;
        private int count;
        private decimal itemDiscount;
        private long itemPrice;
        private Product product;//aggregation

        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductTransactionItem>
        {
            public Configuration()
            {
                
                HasRequired(current => current.ParentTransaction)
                    .WithMany(ProductTransaction => ProductTransaction.items)
                    .WillCascadeOnDelete(true);
            }
        }

        public ProductTransactionItem()
        {
            itemDiscount = 0;
        }


        #region R/W Properties

        //for one to many relation
        public ProductTransaction ParentTransaction { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public long ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public decimal ItemDiscount
        {
            get { return itemDiscount; }
            set { itemDiscount = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        [System.ComponentModel.DataAnnotations.Key]
	    public int Code
	    {
	       	get { return code;}
		    set { code = value;}
	    }


        //gheymate forooshande , faghat dar tarakonesh haye kharid meghdar dehi mishavad ya nemishavad.
        public long? BuyerPrice
        {
            get { return buyerPrice; }
            set { buyerPrice = value; }
        }

        #endregion


        #region ReadOnly Properties
        public long TotalDiscount
        {
            get { return (long)(itemDiscount * count); }
        }
        public long TotalPrice
        {
            get { return itemPrice * count; }
        }
        public long TotalPriceAfterDiscount
        {
            get { return TotalPrice - TotalDiscount; }
        }
        #endregion
    }
}
