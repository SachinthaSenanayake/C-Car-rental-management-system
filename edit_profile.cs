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
    public partial class edit_profile : UserControl
    {

        private static edit_profile _instance;
        public static edit_profile Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new edit_profile();
                return _instance;
            }
        }
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public edit_profile()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=car_rental; user=root; Pwd=; SslMode=none");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update login set password='" + this.textBox3.Text +  "' where password='" + this.textBox2.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Password Changed");
                while (MyReader2.Read())
                {
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
