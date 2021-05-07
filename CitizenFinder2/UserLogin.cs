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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        SqlConnection sc2 = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            sc2.Open();
            string query = "Select * from User_Login Where [NID No] = '" + textBox_NID.Text.Trim() + "' and Password = '" + textBox_Pass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sc2);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            sc2.Close();

           /* if (textBox_NID.Text == string.Empty || textBox_Pass.Text == string.Empty)
            {

                MessageBox.Show("Both NID no and password required!!");

            } */
             if (dt1.Rows.Count == 1)
            {

                User_HomePage f3 = new User_HomePage();
                this.Hide();
                f3.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password!!");
            }


        }
    }
}
