using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NImal_furniture.Repository;
using NImal_furniture.Models;

namespace NImal_furniture
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }


        private void ReadClients()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product name");
            dataTable.Columns.Add("Product type");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            var repo = new clients_repo();
            var clients = repo .GetClients();

            foreach (var client in clients) { 

            var row = dataTable.NewRow();

                row["ID"] = clients.id();
                row["Product Name"] = clients.name();
                row["Product Type"] = clients.type();
                row["Quantity"] = clients.quantity();
                row["Price"] = clients.price();

                dataTable.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_btn(object sender, EventArgs e)
        {

        }

        private void Update_btn(object sender, EventArgs e)
        {

        }

        private void Delete_btn(object sender, EventArgs e)
        {

        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
