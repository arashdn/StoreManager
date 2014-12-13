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

        public void save(ProductTransaction pt)
        {
            ProductTransactions.Add(pt);
            SaveChanges();
        }

        #endregion

        #region Update Methods

        public void update(Check ck)
        {

        }


        public void update(SuperCategory sc)
        {

        }

        public void update(Category c)
        {

        }

        public void update(Product p)
        {

        }

        public void update(Contact c)
        {

        }

        public void update(MoneyTransaction mt)
        {

        }

        public void update(FinancialTransaction ft)
        {

        }

        public void update(ProductTransaction pt)
        {

        }

        #endregion

        #region Delete Methods

        public void delete(Check ck)
        {

        }


        public void delete(SuperCategory sc)
        {

        }

        public void delete(Category c)
        {

        }

        public void delete(Product p)
        {

        }

        public void delete(Contact c)
        {

        }

        public void delete(MoneyTransaction mt)
        {

        }

        public void delete(FinancialTransaction ft)
        {

        }

        public void delete(ProductTransaction pt)
        {

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
