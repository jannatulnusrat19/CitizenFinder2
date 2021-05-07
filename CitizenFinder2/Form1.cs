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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Nextpage_Click(object sender, EventArgs e)
        {
            Admin_Login f = new Admin_Login();
            this.Hide();
            f.ShowDialog();
            
        }

        private void button_User_Click(object sender, EventArgs e)
        {
            UserLogin f2 = new UserLogin();
            this.Hide();
            f2.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
