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
using Nimal_furniture.Repository;
using Nimal_furniture.Models;
using NImal_furniture;

namespace Nimal_furniture
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            ReadClients();
        }


        private void ReadClients()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product name");
            dataTable.Columns.Add("Product type");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            var repo = new Stock_repo();
            var clients = repo.GetClients();

            foreach (var client in clients)
            {

                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Product Name"] = client.name;
                row["Product Type"] = client.type;
                row["Quantity"] = client.quantity;
                row["Price"] = client.price;

                dataTable.Rows.Add(row);
            }
            this.clientstable.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_btn(object sender, EventArgs e)
        {
            create_client form = new create_client();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }
        }

        private void Update_btn(object sender, EventArgs e)
        {
            var val = this.clientstable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);
            var repo = new Stock_repo();
            var client = repo.GetClients(clientId);
            if (client == null) return;

            create_client form = new create_client();
            form.EditClient(client);

            if (form.ShowDialog() == DialogResult.OK)
            {

                ReadClients();
            }
        }


        private void Delete_btn(object sender, EventArgs e)
        {
            var val = this.clientstable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this stock from the inventory?", "Delete Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new Stock_repo();
            repo.DeleteClient(clientId);
            ReadClients();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
