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
    public partial class report : UserControl
    {
        private static report _instance;
        public static report Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new report();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public report()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost; database=car_rental; username=root; Password =; SslMode=none");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "select * from customers;";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "select * from car_manag;";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Query = "select * from booking;";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}
