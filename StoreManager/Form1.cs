using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.Entity;

namespace StoreManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreModels.Check ch = new StoreModels.Check()
            {
                Date = DateTime.Now,
                Price = 2000,
                VosoolStatus = StoreModels.Check.VosoolStatuses.pishAzMoed,
                BankBranch = "1234"

            };

            DBContext myDb = new DBContext();
            myDb.save(ch);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StoreModels.SuperCategory sc = new StoreModels.SuperCategory()
            {
                Name = "سوپر دسته1"
            };
            DBContext myDb = new DBContext();
            myDb.save(sc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBContext myDb = new DBContext();
            myDb.superCategories.Where(o => o.Name == "سوپر دسته1").Load();
            var scats = myDb.superCategories.ToList();

            StoreModels.SuperCategory sc;
            if (scats.Count == 0)
                sc = new StoreModels.SuperCategory()
                {
                    Name = "سوپر دسته جدید"
                };
            else
                sc = scats[0];

            StoreModels.Category c = new StoreModels.Category()
            {
                Name = "دسته1",
                SuperCategory = sc
            };

            myDb.save(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBContext myDb = new DBContext();
            myDb.categories.Where(o => o.Name == "دسته1").Load();
            var cats = myDb.categories.ToList();

            StoreModels.Category c;
            if (cats.Count == 0)
            {
                c = new StoreModels.Category()
                {
                    Name = "دسته جدید"
                };
            }
                
            else
                c = cats[0];
            StoreModels.Product p = new StoreModels.Product()
            {
                Availability = 10,
                BuyPrice = 1000,
                SellPrice = 1500,
                Category = c,
                Name = "محصول1",
            };

          
            myDb.save(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StoreModels.Contact con = new StoreModels.Contact()
            {
                Name="Arash",
                Type=StoreModels.Contact.Types.Person,
                Phone="09355000000"
            };
            DBContext myDB = new DBContext();
            myDB.save(con);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StoreModels.MoneyTransaction mt = new StoreModels.MoneyTransaction()
                {
                    CreationDate = DateTime.Now,
                    IsPersonal = true,
                    TotalPrice = 10000,
                    Type = StoreModels.MoneyTransaction.MTTypes.Hazine
                    
                };
                DBContext myDB = new DBContext();
                myDB.save(mt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                StoreModels.FinancialTransaction ft = new StoreModels.FinancialTransaction()
                {
                    CreationDate = DateTime.Now,
                    IsPersonal = true,
                    TotalPrice = 10000,
                    Type = StoreModels.FinancialTransaction.FTTypes.Talab,
                    PayType = StoreModels.Transaction.PaymentTypes.Naghd

                };
                DBContext myDB = new DBContext();
                myDB.save(ft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }
    }
}
