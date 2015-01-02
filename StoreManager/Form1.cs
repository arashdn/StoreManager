using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            analogClockControl1.Value = DateTime.Now;
        }

        void refresh()
        {
            try
            {
                listView2.Items.Clear();
                DBContext myDB = new DBContext();
                myDB.products.Where(i => i.Availability < 10).Load();
                var lst = myDB.products.Where(i => i.Availability < 10).OrderBy(i => i.Availability).ToList();
                foreach (StoreModels.Product item in lst)
                {
                    ListViewItem lvi = new ListViewItem(new[] { item.Name, item.Availability.ToString() });
                    //listView2.Items.Add(lvi);
                    listView2.Invoke((MethodInvoker)delegate
                    {
                        listView2.Items.Add(lvi);
                    });
                }

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                String s = "خطا در خواندن اطلاعات از پایگاه داده\nمشخصات فنی:\n";
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
            finally
            {
                listView2.Invoke((MethodInvoker)delegate
                {
                    listView2.Visible = true;
                });
                circularProgress1.Invoke((MethodInvoker)delegate
                {
                    circularProgress1.Visible = false;
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgress1.IsRunning = true;
            listView2.Visible = false;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {
            string todayshamsi;
            PersianCalendar dater = new PersianCalendar();
            string year = dater.GetYear(System.DateTime.Now).ToString();
            int monnum = dater.GetMonth(System.DateTime.Now);
            int day = dater.GetDayOfMonth(System.DateTime.Now);
            int dayOfWeek = (int)System.DateTime.Now.DayOfWeek;
            string week = "";

            switch (dayOfWeek)
            {
                case 1:
                    week = "دوشنبه";
                    break;
                case 2:
                    week = "سه شنبه";
                    break;
                case 3:
                    week = "چهارشنبه";
                    break;
                case 4:
                    week = "پنجشنبه";
                    break;
                case 5:
                    week = "جمعه";
                    break;
                case 6:
                    week = "شنبه";
                    break;
                case 7:
                case 0:
                    week = "یکشنبه";
                    break;
                default:
                    week = "";
                    break;
            }

            string month = "";
            switch (monnum)
            {
                case 1:
                    month = "فروردین";
                    break;
                case 2:
                    month = "اردیبهشت";
                    break;
                case 3:
                    month = "خرداد";
                    break;
                case 4:
                    month = "تیر";
                    break;
                case 5:
                    month = "مرداد";
                    break;
                case 6:
                    month = "شهریور";
                    break;
                case 7:
                    month = "مهر";
                    break;
                case 8:
                    month = "آبان";
                    break;
                case 9:
                    month = "آذر";
                    break;
                case 10:
                    month = "دی";
                    break;
                case 11:
                    month = "بهمن";
                    break;
                case 12:
                    month = "اسفند";
                    break;
            }//end switch
            todayshamsi = "امروز\n" + week + "   " + day + " " + month + " " + year;
            label1.Text = todayshamsi;
            //label1.Text = ((int)System.DateTime.Now.DayOfWeek).ToString();
        }

        private void bubbleBar1_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            ProductFrm pf = new ProductFrm();
            pf.ShowDialog();
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_old f = new Form1_old();
            f.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            refresh();
        }


        void notCompeleteYet()
        {
            DevComponents.DotNetBar.ToastNotification.Show(this, "\nاین قسمت پیاده سازی نشده\n", null, 5000,
                DevComponents.DotNetBar.eToastGlowColor.Red, (bubbleBar1.Size.Width) / 2, bubbleBar1.Location.Y - bubbleBar1.Size.Height + 15);
        }
        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

            notCompeleteYet();
            
        }

        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            notCompeleteYet();
        }

        private void bubbleButton4_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            notCompeleteYet();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            notCompeleteYet();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Arash Dargahi , Saeed Piri\nDevelopment version 0.1", "Still Not Compelete", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }
    }
}
