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
using MySqlX.XDevAPI;

namespace NImal_furniture
{
    public partial class create_client : Form
    {
        public create_client()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();

            client.id = 0;
            client.name = this.tb_name.Text;
            client.type = this.tb_type.Text;
            client.quantity = 0;
            client.price = 0;

            var repo = new clients_repo();
            repo.CreateClients(client);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
