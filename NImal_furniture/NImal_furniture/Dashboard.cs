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

namespace NImal_furniture
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=inventory;User Id=root;Password=Mydemons212@;Port=3306;";
        public Dashboard()
        {
            InitializeComponent();
          
        }
        private void orders_btn(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void inventory_btn(object sender, EventArgs e)
        {

        }

        private void dashboard_btn(object sender, EventArgs e)
        {

        }

        private void update_btn(object sender, EventArgs e)
        {

        }

        private void txtCurrentStock(object sender, EventArgs e)
        {

        }

        private void txtStockValue(object sender, EventArgs e)
        {

        }

        private void txtRemainingTime(object sender, EventArgs e)
        {

        }

        private void txtLastUpdate(object sender, EventArgs e)
        {

        }

        private void textbox1(object sender, EventArgs e)
        {
            
        }
    }
}
