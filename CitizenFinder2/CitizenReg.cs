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
    public partial class CitizenReg : Form
    {
        public CitizenReg()
        {
            InitializeComponent();
        }
        SqlConnection sc1 = new SqlConnection("Data Source=DESKTOP-IQOQ25D\\SQLEXPRESS;Initial Catalog=CitizenFinder;Persist Security Info=True;User ID=sa;Password=turna");
        private void label_DOB_Click(object sender, EventArgs e)
        {

        }

        private void label_Gender_Click(object sender, EventArgs e)
        {

        }

       

        private void button_Register_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg = new SqlCommand("insert into Citizen_Details values(' " + textBox_Name.Text + " ','"+int.Parse(textBox_NID.Text) +"' ,' "  +DateTime.Parse(textBox_DOB.Text) + " ', '"+textBox_Gen.Text+ "'," + " ' " + textBox_Status.Text + " ', ' " + textBox_BG.Text + " '," +
                "' " + textBox_Add.Text + " ', ' " + textBox_Occ.Text + " ', ' " + textBox_Pass.Text + " ')", sc1);
            creg.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("Registration completed!");
            


            



        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg = new SqlCommand("Update Citizen_Details set [Marital Status]= ' " + textBox_Status.Text + " ', [Blood Group]=' " + textBox_BG.Text + " ', Occupation=' " + textBox_Occ.Text + " ' where [NID No]= '" + int.Parse(textBox_NID.Text) + "'", sc1);
            creg.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("Table has been updated!");
            User_HomePage f2 = new User_HomePage();
            this.Hide();
            f2.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg = new SqlCommand("Delete from Citizen_Details where [NID No]='" + int.Parse(textBox_NID.Text) + "'", sc1);
            creg.ExecuteNonQuery();
            sc1.Close();

            MessageBox.Show("One entry has been deleted!");
            Home_Page f2 = new Home_Page();
            this.Hide();
            f2.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Page h6 = new Home_Page();
            this.Hide();
            h6.Show();
        }

        private void button_CreateLogin_Click(object sender, EventArgs e)
        {
            sc1.Open();
            SqlCommand creg1 = new SqlCommand("insert into User_Login values('" + int.Parse(textBox_NID.Text) + "' ,'"+ textBox_Pass.Text + " ')", sc1);
            creg1.ExecuteNonQuery();
            sc1.Close();
            MessageBox.Show("Login Created!");
            Home_Page f2 = new Home_Page();
            this.Hide();
            f2.Show();

        }
    }
}
