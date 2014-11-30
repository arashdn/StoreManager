using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class Product
    {
        private int availability;
        private string barCode;
        private long buyPrice;
        private  Category category;
        private int code;
        private string name;
        private long sellPrice;

        public long SellPrice//esm ha be in soorate
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public long BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }

        public string BarCode
        {
            get { return  barCode; }
            set {  barCode = value; }
        }

        public int Availability
        {
            get { return availability; }
            set { availability = value; }
        }


    }
}
