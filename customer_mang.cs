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
    public partial class customer_mang : UserControl
    {

        private static customer_mang _instance;
        public static customer_mang Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new customer_mang();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        

        public customer_mang()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost; database=car_rental; username=root; Password =; SslMode=none ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string F_Nname = textBox1.Text;
            string L_Name = textBox2.Text;
            string Phone = textBox3.Text;
            string DOB = dateTimePicker1.Text;
            string Licence = textBox5.Text;
            string Issue_Date = dateTimePicker2.Text;

            cmd = new MySqlCommand();
            cmd.CommandText = "Insert into customers values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Text + "')";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == "" || dateTimePicker2.Text == "")
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

                string Query = "select * from customers;";
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
                string Query = "update customers set F_Nname='" + this.textBox1.Text + "',L_Name='" + this.textBox2.Text + "',Phone='" + this.textBox3.Text + "',DOB='" + this.dateTimePicker1.Text + "',Licence='" + this.textBox5.Text + "',Issue_Date='" + this.dateTimePicker2.Text + "' where F_Nname='" + this.textBox1.Text + "';";
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
            string Query1 = "select * from customers;";
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
            string Query1 = "select * from customers where F_Nname like '" + textBox1.Text + "%'";
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
                string Query = "delete from customers where F_Nname='" + this.textBox1.Text + "';";

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
            string Query1 = "select * from customers;";
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
                textBox3.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
                textBox5.Text = string.Empty;
                dateTimePicker2.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string Query1 = "select * from customers where F_Nname like '" + textBox1.Text + "%'";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            con.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void customer_mang_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
