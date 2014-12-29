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
using DevComponents.DotNetBar.Controls;

namespace StoreManager
{
    public partial class ProductFrm : Form
    {
        public ProductFrm()
        {
            InitializeComponent();
            
        }
        DBContext myDb;
        List<StoreModels.Product> lst;
        void refresh()
        {
            try
            {
                dataGridViewX1.Columns.Clear();
                myDb = new DBContext();
                //myDb.products.Load();
                lst = myDb.products.Include("Category").ToList();
                dataGridViewX1.DataSource = lst;
                dataGridViewX1.Columns["category"].Visible = false;



                dataGridViewX1.Columns["code"].HeaderText = "کد";
                dataGridViewX1.Columns["code"].ReadOnly = true;
                dataGridViewX1.Columns["code"].DisplayIndex = 0;
                dataGridViewX1.Columns["BarCode"].HeaderText = "بارکد";
                dataGridViewX1.Columns["BarCode"].DisplayIndex = 1;
                dataGridViewX1.Columns["Name"].HeaderText = "نام محصول";
                dataGridViewX1.Columns["Name"].DisplayIndex = 2;
                dataGridViewX1.Columns["SellPrice"].HeaderText = "قیمت فروش";
                dataGridViewX1.Columns["SellPrice"].DisplayIndex = 3;
                dataGridViewX1.Columns["BuyPrice"].HeaderText = "قیمت خرید";
                dataGridViewX1.Columns["BuyPrice"].DisplayIndex = 4;
                dataGridViewX1.Columns["Availability"].HeaderText = "موجودی";
                dataGridViewX1.Columns["Availability"].DisplayIndex = 5;

                DataGridViewButtonXColumn bc = new DataGridViewButtonXColumn()
                {
                    Name = "Delete",
                    DisplayIndex = 6,
                    HeaderText = "حذف",
                };
                bc.BeforeCellPaint += Delete_BeforeCellPaint;
                dataGridViewX1.Columns.Add(bc);




            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                String s = "خطا در بارگزاری اطلاعات از پایگاه داده\nمشخصات فنی:\n";
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
        }
        private void ProductFrm_Load(object sender, EventArgs e)
        {

            refresh();
        }



        void Delete_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewButtonXColumn bcx = sender as DataGridViewButtonXColumn;


            if (bcx != null)
            {
                bcx.Text = "حذف";
                bcx.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
                bcx.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
                bcx.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myDb.SaveChanges();
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
            
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonXCell cell = dataGridViewX1.CurrentCell as DataGridViewButtonXCell;

            if (cell != null)
            {
                DataGridViewButtonXColumn bc = dataGridViewX1.Columns[e.ColumnIndex] as DataGridViewButtonXColumn;

                if (bc != null)
                {
                    switch (bc.Name)
                    {
                        case "Delete":
                            DialogResult dr = MessageBox.Show("آیا از حذف محصول \"" + dataGridViewX1.Rows[e.RowIndex].Cells["Name"].Value + "\" اطمینان دارید؟","تایید حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if(dr==System.Windows.Forms.DialogResult.Yes)
                            {
                                int m = (int)dataGridViewX1.Rows[e.RowIndex].Cells["code"].Value;
                                DBContext myDb2 = new DBContext();
                                StoreModels.Product p = myDb2.products.Where(i => i.Code == m).First();
                                try
                                {
                                    myDb2.delete(p);
                                    refresh();
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
                                catch (Exception ex)
                                {
                                    MessageBox.Show("خطایی رخ داد\n" + ex.Message);
                                }
                                
                            }
                            break;

                    }
                }
            }//if cell ! null
        }//void dataGridViewX1_CellContentClick

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void saveEdits()
        {
            try
            {
                myDb.SaveChanges();
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
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد\n" + ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            saveEdits();
        }

        private void افزودنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
            refresh();

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ذخیرهتغییراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveEdits();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && lst != null)
                dataGridViewX1.DataSource = lst.ToList();
            else
                dataGridViewX1.DataSource = lst.Where(i => i.Name.Contains(textBox1.Text)).ToList();
            dataGridViewX1.Columns["Delete"].DisplayIndex = 7;
        }
    }
}
