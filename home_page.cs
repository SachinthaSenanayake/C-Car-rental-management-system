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
    public partial class home_page : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public home_page()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (!panel3.Controls.Contains(customer_mang.Instance))
                {
                    panel3.Controls.Add(customer_mang.Instance);
                    customer_mang.Instance.Dock = DockStyle.Fill;
                    customer_mang.Instance.BringToFront();

                }
                else
                    customer_mang.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (!panel3.Controls.Contains(vehicle__category.Instance))
                {
                    panel3.Controls.Add(vehicle__category.Instance);
                    vehicle__category.Instance.Dock = DockStyle.Fill;
                    vehicle__category.Instance.BringToFront();

                }
                else
                    vehicle__category.Instance.BringToFront();
            }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (!panel3.Controls.Contains(car_manag.Instance))
                {
                    panel3.Controls.Add(car_manag.Instance);
                    car_manag.Instance.Dock = DockStyle.Fill;
                    car_manag.Instance.BringToFront();

                }
                else
                    car_manag.Instance.BringToFront();
            }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (!panel3.Controls.Contains(booking.Instance))
                {
                    panel3.Controls.Add(booking.Instance);
                    booking.Instance.Dock = DockStyle.Fill;
                    booking.Instance.BringToFront();

                }
                else
                    booking.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel3.Controls.Contains(edit_profile.Instance))
            {
                panel3.Controls.Add(edit_profile.Instance);
                edit_profile.Instance.Dock = DockStyle.Fill;
                edit_profile.Instance.BringToFront();

            }
            else
                edit_profile.Instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (!panel3.Controls.Contains(report.Instance))
                {
                    panel3.Controls.Add(report.Instance);
                    report.Instance.Dock = DockStyle.Fill;
                    report.Instance.BringToFront();

                }
                else
                    report.Instance.BringToFront();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

           
            }
    }
}
