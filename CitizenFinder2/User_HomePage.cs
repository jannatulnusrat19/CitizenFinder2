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
    public partial class User_HomePage : Form
    {
        public User_HomePage()
        {
            InitializeComponent();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            AboutbyUser ab = new AboutbyUser();
            ab.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            User_Search s = new User_Search();
            this.Hide();
            s.Show();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            User_Update update = new User_Update();
            this.Hide();
            update.Show();
            

        }
    }
}
