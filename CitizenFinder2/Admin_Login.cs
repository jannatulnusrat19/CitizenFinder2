using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenFinder2
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sc.Open();
            string query = "Select * from Admin_Login Where Username = '" + textBox_Username.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query, sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            sc.Close();

            if (dt.Rows.Count == 1)
            {
                Home_Page h3 = new Home_Page();
                this.Hide();
                h3.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password!!");
            }


        }
    }
}
