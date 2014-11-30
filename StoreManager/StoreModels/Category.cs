using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Category
    {
        private int code;
        private string name;
        private SuperCategory superCategory;

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


        public SuperCategory SuperCategory
        {
            get { return superCategory; }
            set { superCategory = value; }
        }


    }
}
