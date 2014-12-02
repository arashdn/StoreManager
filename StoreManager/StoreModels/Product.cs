using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager.StoreModels
{
    class Product
    {
        private int availability;
        private string barCode;
        private long buyPrice;
        private Category category;
        private int code;
        private string name;
        private long sellPrice;






        [System.ComponentModel.DataAnnotations.Required]
        public long SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        [System.ComponentModel.DataAnnotations.Key]
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public long BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }

        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public int Availability
        {
            get { return availability; }
            set { availability = value; }
        }


    }
}
