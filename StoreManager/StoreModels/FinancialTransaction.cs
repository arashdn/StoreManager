using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.StoreModels
{
    class FinancialTransaction : Transaction
    {
        public enum FTTypes
        {
            Bedehi = 1,
            Talab
        }


        private bool isPersonal;
        private PaymentTypes payType;
        private FTTypes type;
        private DateTime? deadLine;

        public DateTime? DeadLine
        {
            get { return deadLine; }
            set { deadLine = value; }
        }


        [System.ComponentModel.DataAnnotations.Required]
        public FTTypes Type
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
