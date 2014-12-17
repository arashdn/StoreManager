using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class Store
    {
        public void sell(ProductTransactionItem pti, DateTime date, string not = null, bool isPaid = true, Contact con = null, Check chk = null)
        {
            List<ProductTransactionItem> list = new List<ProductTransactionItem>();
            list.Add(pti);
            sell(list, date,not,isPaid,con,chk);
        }

        public void sell(List<ProductTransactionItem> pti , DateTime date,  string not = null , bool isPaid = true ,Contact con = null , Check chk = null)
        {
            DateTime? paydate = null;
            if (isPaid)
                paydate = DateTime.Now;
            ProductTransaction pt = new ProductTransaction()
            {
                CreationDate = date,
                PaymentDate = paydate,
                Check = chk,
                Contact = con,
                Note = not,
            };
            DBContext myDBContext = new DBContext();
            foreach (ProductTransactionItem item in pti)
            {
                pt.items.Add(item);
                myDBContext.products.Attach(item.Product); //association with product and dbcontext
            }

            myDBContext.save(pt);
            
        }
    
    
        public void buy(ProductTransactionItem pti, DateTime date, string not = null, bool isPaid = true, Contact con = null, Check chk = null)
        {

        }

        public void buy(List<ProductTransactionItem> pti , DateTime date,  string not = null , bool isPaid = true ,Contact con = null , Check chk = null)
        {

        }



        internal void sell()
        {
            throw new NotImplementedException();
        }
    }
}
