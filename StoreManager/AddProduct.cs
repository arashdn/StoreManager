using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" ||textBox3.Text=="" ||textBox4.Text=="" )
            {
                MessageBox.Show("لطفا تمام اطلاعات را تکمیل کنید", "خطا");
                return;
            }
            try
            {
                long buyPrice = long.Parse(textBox3.Text);
                long sellPrice = long.Parse(textBox4.Text);
                int avail = (int)numericUpDown1.Value;
                StoreModels.Product p = new StoreModels.Product()
                {
                    Name=textBox1.Text,
                    BarCode=textBox2.Text,
                    BuyPrice = buyPrice,
                    SellPrice = sellPrice,
                    Availability = avail,
                    Category=null
                };
                DBContext myDb = new DBContext();
                myDb.save(p);
                this.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                String s = "خطا در ذخیره اطلاعات در پایگاه داده\nمشخصات فنی:\n";
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        s = s + "\nProperty: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage;
                    }
                }
                MessageBox.Show(s);
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطایی رخ داد\n" + ex.Message);
            }

        }
    }
}
