using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_Project
{
    public partial class booking : UserControl
    {
        private static booking _instance;
        public static booking Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new booking();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public booking()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=car_rental; user=root; Pwd=;  SslMode=none");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer = textBox1.Text;
            string car = textBox2.Text;
            string rent_date = dateTimePicker1.Text;
            string return_date = dateTimePicker2.Text;
            string days= textBox5.Text;
            string amount= textBox6.Text;

            cmd = new MySqlCommand();
            cmd.CommandText = "Insert into booking values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" || textBox5.Text == "" || textBox6.Text == "")
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

                string Query = "select * from booking;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView3.DataSource = dTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update booking set customer='" + this.textBox1.Text + "',car='" + this.textBox2.Text + "',rent_date='" + this.dateTimePicker1.Text + "',return_date='" + this.dateTimePicker2.Text + "',days='" + this.textBox5.Text + "',amount='" + this.textBox6.Text + "' where customer='" + this.textBox1.Text + "';";
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
            string Query1 = "select * from booking;";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable(); 
            MyAdapter.Fill(dTable);
            dataGridView3.DataSource = dTable;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query1 = "select * from booking where customer like '" + textBox1.Text + "%'";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView3.DataSource = dTable;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from booking where customer='" + this.textBox1.Text + "';";

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
            string Query1 = "select * from booking;";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView3.DataSource = dTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                dateTimePicker2.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }
    }
}
