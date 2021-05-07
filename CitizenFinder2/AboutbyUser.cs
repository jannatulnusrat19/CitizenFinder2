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
    public partial class AboutbyUser : Form
    {
        public AboutbyUser()
        {
            InitializeComponent();
        }

        private void AboutbyUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_HomePage hp2 = new User_HomePage();
            this.Hide();
            hp2.Show();
        }
    }
}
