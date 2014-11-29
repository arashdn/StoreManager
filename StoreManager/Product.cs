using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager
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

        public long MyProperty
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

        public string MyProperty
        {
            get { return name; }
            set { name = value; }
        }

        public int MyProperty
        {
            get { return code; }
            set { code = value; }
        }

        public Category MyProperty
        {
            get { return category; }
            set { category = value; }
        }

        public long MyProperty
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }

        public string MyProperty
        {
            get { return  barCode; }
            set {  barCode = value; }
        }

        public int MyProperty
        {
            get { return availability; }
            set { availability = value; }
        }

        public int Code()
        {

        }
    }
}
