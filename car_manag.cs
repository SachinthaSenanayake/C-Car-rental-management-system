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
    public partial class car_manag : UserControl
    {
        private static car_manag _instance;
        public static car_manag Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new car_manag();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public car_manag()
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
            string car_name = textBox1.Text;
            string category = comboBox1.Text;
            string brand = textBox3.Text;
            string color = textBox4.Text;
            string mileage = textBox5.Text;
            string car_number = textBox6.Text;
            string daily_price = textBox7.Text;

            cmd = new MySqlCommand();
            cmd.CommandText = "Insert into car_manag values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
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

                string Query = "select * from car_manag;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                try
                {
             
                    string Query = "update car_manag set car_name='" + this.textBox1.Text + "',category='" + this.comboBox1.Text + "',brand='" + this.textBox3.Text + "',color='" + this.textBox4.Text + "',mileage='" + this.textBox5.Text + "',car_number='" + this.textBox6.Text + "',daily_price='" + this.textBox7.Text + "' where car_name='" + this.textBox1.Text + "';";
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
                string Query1 = "select * from car_manag;";
                MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand3;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
            }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query1 = "select * from car_manag where car_name like '" + textBox1.Text + "%'";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView2.DataSource = dTable;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from car_manag where car_name='" + this.textBox1.Text + "';";

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
            string Query1 = "select * from car_manag;";
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand3;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView2.DataSource = dTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = string.Empty;
                comboBox1.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void car_manag_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
