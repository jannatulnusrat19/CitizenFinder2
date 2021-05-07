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
    public partial class Citizen_List : Form
    {
        public Citizen_List()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void Citizen_List_Load(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page b = new Home_Page();
            this.Hide();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit() ;  
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                SqlCommand sme = new SqlCommand("Select * from Citizen_Details order by Address", sc);
                SqlDataAdapter sd1 = new SqlDataAdapter(sme);
                DataSet dt = new DataSet();
                sd1.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[0].HeaderText = "    Name   ";
                sc.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
