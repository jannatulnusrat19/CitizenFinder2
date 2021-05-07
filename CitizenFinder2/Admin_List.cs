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
    public partial class Admin_List : Form
    {
        public Admin_List()
        {
            InitializeComponent();
        }
        SqlConnection sc= new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void Admin_List_Load(object sender, EventArgs e)
        {
           

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page b1 = new Home_Page();
            this.Hide();
            b1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                SqlCommand sme = new SqlCommand("Select ID,Name,[Birth date],Address,[Email id] from Admin_Details_Main", sc);
                SqlDataAdapter sd1 = new SqlDataAdapter(sme);
                DataSet dt = new DataSet();
                sd1.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Employee Name";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Date Of Birth";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Address";
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[4].HeaderText = "Email ID";
                sc.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
    }
}
