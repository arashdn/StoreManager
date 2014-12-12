using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class MoneyTransaction:Transaction
    {

        public enum Types
        {
            Hazine = 1,
            DarAmad
        }


        private int isPersonal;
        private PaymentTypes payType;

        private Types type;


        [System.ComponentModel.DataAnnotations.Required]
        public Types Type
        {
            get { return type; }
            set { type = value; }
        }

        [System.ComponentModel.DataAnnotations.Required]
        public PaymentTypes PayType
        {
            get { return payType; }
            set { payType = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public int IsPersonal
        {
            get { return isPersonal; }
            set { isPersonal = value; }
        }
        
    }
}
