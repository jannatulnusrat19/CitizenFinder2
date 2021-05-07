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
    public partial class NewAdminReg : Form
    {
        public NewAdminReg()
        {
            InitializeComponent();
        }
        SqlConnection sc1 = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");

        private void btn_Register_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand ar = new SqlCommand("insert into Admin_Details_Main values(' " + (textBox_EmpID.Text) + " ',' " + textBox_Name.Text+ " ',' " + DateTime.Parse(textBox_DOB.Text) + " ', ' " + textBox_Address.Text + " '," +
                " ' " + textBox_Email.Text + " ', ' " + textBox_Username.Text + " ', ' " + textBox_Password.Text + " ')", sc1);
            ar.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("Registration completed!");
           

        }

        private void button_Delete_Click_1(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg = new SqlCommand("Delete  from Admin_Details_Main where ID='" + textBox_EmpID.Text + "'", sc1);
            creg.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("One admin has been deleted!");
            Home_Page f1 = new Home_Page();
            this.Hide();
            f1.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page h4 = new Home_Page();
            this.Hide();
            h4.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_CreateLogin_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg1 = new SqlCommand("insert into Admin_Login values('" + textBox_Username.Text + "' ,'" + textBox_Password.Text + " ')", sc1);
            creg1.ExecuteNonQuery();
            sc1.Close();
            MessageBox.Show("Login Created!");
            Home_Page f2 = new Home_Page();
            this.Hide();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
