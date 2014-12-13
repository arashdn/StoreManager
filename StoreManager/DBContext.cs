using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreManager.StoreModels;

namespace StoreManager
{
    class DBContext : System.Data.Entity.DbContext
    {
        static DBContext()
        {
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DBContext>());
        }
        public DBContext() : base("StoreManager")
        {

        }


        #region Save Methods
        public void save(Check ck)
        {
            checks.Add(ck);
            SaveChanges();
        }


        public void save(SuperCategory sc)
        {
            superCategories.Add(sc);
            SaveChanges();
        }

        public void save(Category c)
        {
            categories.Add(c);
            SaveChanges();
        }

        public void save(Product p)
        {
            products.Add(p);
            SaveChanges();
        }

        public void save(Contact c)
        {
            contacts.Add(c);
            SaveChanges();
        }

        public void save(MoneyTransaction mt)
        {
            moneyTransactions.Add(mt);
            SaveChanges();
        }

        public void save(FinancialTransaction ft)
        {
            FinancialTransactions.Add(ft);
            SaveChanges();
        }


        #endregion




        public System.Data.Entity.DbSet<Check> checks { get; set; }
        public System.Data.Entity.DbSet<SuperCategory> superCategories { get; set; }
        public System.Data.Entity.DbSet<Category> categories { get; set; }
        public System.Data.Entity.DbSet<Product> products { get; set; }
        public System.Data.Entity.DbSet<Contact> contacts { get; set; }
        public System.Data.Entity.DbSet<MoneyTransaction> moneyTransactions { get; set; }
        public System.Data.Entity.DbSet<FinancialTransaction> FinancialTransactions { get; set; }
        public System.Data.Entity.DbSet<ProductTransaction> ProductTransactions { get; set; }
        public System.Data.Entity.DbSet<ProductTransactionItem> ProductTransactionItemes { get; set; }


        protected override void OnModelCreating (System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProductTransactionItem.Configuration());
        }


    }
}
