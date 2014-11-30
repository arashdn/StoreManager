using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class SuperCategory
    {
        private int code;
        private string name;

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
    }
}
