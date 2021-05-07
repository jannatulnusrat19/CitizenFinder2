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
    public partial class User_Search : Form
    {
        public User_Search()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void button_Find_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand sme = new SqlCommand("Select * from Citizen_Details where [NID No]= '" + int.Parse(textBox_Nid.Text) + "'", sc);
            SqlDataAdapter sd1 = new SqlDataAdapter(sme);
            DataSet dt = new DataSet();
            sd1.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[0].HeaderText = "    Name   ";
            sc.Close();
        }

        

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User_HomePage hp = new User_HomePage();
            this.Hide();
            hp.Show();
        }
    }
}
