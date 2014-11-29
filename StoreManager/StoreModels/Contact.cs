using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class Contact
    {
        private int code;
        private string name;
        private string note;
        private string phone;
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        
        public string Note
        {
            get { return note; }
            set { note = value; }
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
        
    }
}
