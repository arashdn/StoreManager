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

        private void button8_Click(object sender, EventArgs e)
        {
            DBContext myDB = new DBContext();
            myDB.products.Load();
            StoreModels.Contact c = new StoreModels.Contact(); c = null;
            bool isPaid=true;
            StoreModels.Check ch = new StoreModels.Check(); ch = null;
            var lst = myDB.products.ToList();
            if (lst.Count == 0)
            {
                MessageBox.Show("محصولی ثبت نشده");
                return;
            }

            List<StoreModels.ProductTransactionItem> listpti = new List<StoreModels.ProductTransactionItem>();
            for (int i = 0; i < lst.Count; i++)
            {
                StoreModels.ProductTransactionItem temp = new StoreModels.ProductTransactionItem()
                {
                    Product = lst[i],
                    Count = 3,
                    ItemPrice = lst[0].SellPrice,
                    ItemDiscount = 0,
                };
                listpti.Add(temp);
            }

            Store myStore = new Store();
            myStore.sell(listpti, DateTime.Now,null,isPaid,c,ch);                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                var temp = myDb.checks.Where(i => i.Code == 3).First();
                temp.Price = 1000;
                myDb.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.Check ck = myDb.checks.Where(i => i.Code == 4).First();
                myDb.checks.Attach(ck);
                myDb.delete(ck);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.SuperCategory sc = myDb.superCategories.Where(i => i.Code == 1).FirstOrDefault();
                myDb.superCategories.Attach(sc);
                myDb.delete(sc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.Category c = myDb.categories.Where(i => i.Code == 2).FirstOrDefault();
                myDb.categories.Attach(c);
                myDb.delete(c);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.Product p = myDb.products.Where(i => i.Code == 5).FirstOrDefault();
                myDb.products.Attach(p);
                myDb.delete(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.Contact c = myDb.contacts.Where(i => i.Code==1).FirstOrDefault();
                myDb.contacts.Attach(c);
                myDb.delete(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.MoneyTransaction mt = myDb.moneyTransactions.Where(i => i.Code == 1).FirstOrDefault();
                myDb.moneyTransactions.Attach(mt);
                myDb.delete(mt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                StoreModels.FinancialTransaction ft = myDb.FinancialTransactions.Where(i => i.Code == 2).FirstOrDefault();
                myDb.FinancialTransactions.Attach(ft);
                myDb.delete(ft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DBContext myDb = null;
            try
            {
                myDb = new DBContext();
                myDb.products.Load();
                var lst = myDb.products.ToList();
                if (lst.Count == 0)
                {
                    //لیست خالی
                }
                else
                {
                    bool flag = false;
                    myDb.superCategories.Load();
                    var lst1 = myDb.superCategories.ToList();
                    for (int i = 0; i < lst1.Count; i++)
                    {
                        if (lst1[i].Name =="")
                        {
                            flag = true;
                        }
                        if (!flag)
                        {
                            StoreModels.SuperCategory sc = new StoreModels.SuperCategory()
                            {
                                Name = "سوپر دسته"
                            };
                            myDb.save(sc);
                        }
                    }
                    myDb.categories.Load();
                    var lst2 = myDb.categories.ToList();
                    for (int i = 0; i < lst1.Count; i++)
                    {
                        if (lst2[i].Name == "دسته1")
                        {
                            flag = true;
                        }
                        if (!flag)
                        {
                            StoreModels.Category c = new StoreModels.Category()
                            {
                                Name = "کالا"
                            };
                            myDb.save(c);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
