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
    public partial class register_1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public register_1()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=car_rental; user=root; Pwd=; SslMode=none");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string Fname = textBox2.Text;
                string LName = textBox3.Text;
                string username = textBox4.Text;
                string password = textBox5.Text;
                

                cmd = new MySqlCommand();
                cmd.CommandText = "Insert into login values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please provide all data ಠ_ಠ ");
                }
                else
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Register succsessful.Thank you for joining with us ╰(◡‿◡╰)");
                }
                }
    }
}
