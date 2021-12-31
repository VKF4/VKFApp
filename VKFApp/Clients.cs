using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKFApp
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Form NewClients = new NewClients();
            NewClients.Show();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            Form TypeExport = new TypeExport();
            TypeExport.Show();
        }
    }
}
