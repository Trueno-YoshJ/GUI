using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nimal_furniture.Repository;
using Nimal_furniture.Models;


namespace NImal_furniture
{
    public partial class create_client : Form
    {
        public create_client()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        private int clientId = 0;
        public void EditClient(Clients clients)
        {
            //this.Text = "Edit Client";
            //this.lbTitle.Text = "Edit Client";
            this.lbId.Text = "" + clients.id;
            this.tb_name.Text = clients.name;
            this.tb_type.Text = clients.type;
            this.tb_qty.Text = clients.quantity.ToString();
            this.tb_price.Text = clients.price.ToString();
            this.clientId = clients.id;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();

            client.id = this.clientId;
            client.name = this.tb_name.Text;
            client.type = this.tb_type.Text;
            if (!int.TryParse(this.tb_qty.Text, out client.quantity))
            {
                MessageBox.Show("Invalid quantity entered. Please enter a number.");
                return;
            }
            if (!int.TryParse(this.tb_price.Text, out client.price))
            {
                MessageBox.Show("Invalid price entered. Please enter a number.");
                return;
            }

            var repo = new clients_repo();
            if (client.id == 0)
            {
                repo.CreateClients(client);
            }
            else
            {
                repo.UpdateClients(client);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void create_client_Load(object sender, EventArgs e)
        {

        }
    }
}

