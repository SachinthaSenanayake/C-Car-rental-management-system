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
    public partial class vehicle__category : UserControl
    {
        private static vehicle__category _instance;
        public static vehicle__category Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new vehicle__category();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public vehicle__category()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=car_rental; user=root; Pwd=;  SslMode=none");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string F_Nname = textBox1.Text;
            string L_Name = textBox2.Text;

            cmd = new MySqlCommand();
            cmd.CommandText = "Insert into car_categ values('" + textBox1.Text + "','" + textBox2.Text + "')";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide all data");
            }
            else
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted");

                string Query = "select * from car_categ;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update car_categ set Name='" + this.textBox1.Text + "',Description='" + this.textBox2.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Query1 = "select * from car_categ;";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query1 = "select * from car_categ where Name like '" + textBox1.Text + "%'";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from car_categ where Name='" + this.textBox1.Text + "';";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");


                while (MyReader2.Read())
                {
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Query1 = "select * from car_categ;";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
