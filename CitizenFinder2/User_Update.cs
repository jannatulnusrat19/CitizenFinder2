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
    public partial class User_Update : Form
    {
        public User_Update()
        {
            InitializeComponent();
        }
        SqlConnection sc1 = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            User_HomePage hp = new User_HomePage();
            this.Hide();
            hp.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg = new SqlCommand("Update Citizen_Details set [Marital Status]= ' " + textBox_Status.Text + " ', [Blood Group]=' " + textBox_BG.Text + " ', Occupation=' " + textBox_Occ.Text + " '  where [NID No]= '" + int.Parse(textBox_NID.Text) + "'", sc1);
            creg.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("Table has been updated!");
            User_HomePage f2 = new User_HomePage();
            this.Hide();
            f2.Show();
        }
    }
}
