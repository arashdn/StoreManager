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


        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
