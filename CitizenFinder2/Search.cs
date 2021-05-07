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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void button_Search_Click(object sender, EventArgs e)
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

        
        private void textBox_Nid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page hp = new Home_Page();
            this.Hide();
            hp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
