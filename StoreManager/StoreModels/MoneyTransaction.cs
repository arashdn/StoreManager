using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class MoneyTransaction:Transaction
    {

        public enum MTTypes
        {
            Hazine = 1,
            DarAmad
        }


        private bool isPersonal;
        private PaymentTypes payType;

        private MTTypes type;

        [System.ComponentModel.DataAnnotations.Schema.Column("MTType")]
        [System.ComponentModel.DataAnnotations.Required]
        public MTTypes Type
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
        public bool IsPersonal
        {
            get { return isPersonal; }
            set { isPersonal = value; }
        }
        
    }
}
