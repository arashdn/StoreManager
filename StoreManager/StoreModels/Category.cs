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
        public SuperCategory SuperCategory
        {
            get { return superCategory; }
            set { superCategory = value; }
        }


    }
}
