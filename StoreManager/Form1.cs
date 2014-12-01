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
                Name="سوپر دسته1"
            };
            DBContext myDb = new DBContext();
            myDb.save(sc);
        }
    }
}
