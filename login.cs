using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_Project
{
    public partial class login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public login()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost; database=car_rental; username=root; Password =; SslMode=none ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {

            register_1 f4 = new register_1();
            f4.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (user == "" || pass == "")
            {
                label5.Text = "*Please enter username and password";
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "Invalid Login");
               
            }
            else if (dr.Read())
            {

                MessageBox.Show("Login successful (｡◕‿◕｡)");
                this.Hide();
                home_page f8 = new home_page();
                f8.Show();


            }
            else
            {
                label5.Text = "Invalid Login please check username and password";
                errorProvider1.Clear();
                errorProvider1.SetError(label5, "Invalid Login");


            }
            con.Close();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
