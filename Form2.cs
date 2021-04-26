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
    public partial class Form2 : Form
    {

        vehicle__category u1;
        customer_mang u2;


        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form2()
        {
            u1 = new vehicle__category();
            u2 = new customer_mang();
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=car_rental; user=root; Pwd=; port=3308");
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void customerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (!panel2.Controls.Contains(vehicle__category.Instance))
                {
                    panel2.Controls.Add(vehicle__category.Instance);
                    vehicle__category.Instance.Dock = DockStyle.Fill;
                    vehicle__category.Instance.BringToFront();

                }
                else
                    customer_mang.Instance.BringToFront();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (!panel2.Controls.Contains(customer_mang.Instance))
                {
                    panel2.Controls.Add(customer_mang.Instance);
                    customer_mang.Instance.Dock = DockStyle.Fill;
                    customer_mang.Instance.BringToFront();

                }
                else
                    customer_mang.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void customer_mang1_Load(object sender, EventArgs e)
        {

        }

        private void carManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { 
            if (!panel2.Controls.Contains(car_manag.Instance))
            {
                panel2.Controls.Add(car_manag.Instance);
               car_manag.Instance.Dock = DockStyle.Fill;
               car_manag.Instance.BringToFront();

            }
            else
                car_manag.Instance.BringToFront();
        }
    }

        private void bookingManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (!panel2.Controls.Contains(booking.Instance))
                {
                    panel2.Controls.Add(booking.Instance);
                    booking.Instance.Dock = DockStyle.Fill;
                    booking.Instance.BringToFront();

                }
                else
                    booking.Instance.BringToFront();
            }
        }
    }
}
