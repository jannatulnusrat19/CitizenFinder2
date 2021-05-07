using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenFinder2
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void btn_NewAdmin_Click(object sender, EventArgs e)
        {
            NewAdminReg a1 = new NewAdminReg();
            this.Hide();
            a1.Show();
        }

        private void btn_CitizenReg_Click(object sender, EventArgs e)
        {
            CitizenReg a2 = new CitizenReg();
            this.Hide();
            a2.Show();
        }

        private void btn_AdminList_Click(object sender, EventArgs e)
        {
            Admin_List a3 = new Admin_List();
            this.Hide();
            a3.Show();
        }

        private void button_CitiList_Click(object sender, EventArgs e)
        {
            Citizen_List a4 = new Citizen_List();
            this.Hide();
            a4.Show();
        }

        private void button_Track_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            this.Hide();
            s.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
