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
    }
}
