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

namespace VKFApp
{
    public partial class NewClients : Form
    {
        private void initalisationConnexionBase()
        {
            string ChaineConnexion;
            ChaineConnexion = "server=localhost;user=root;database=vkfapp;port=3306;password=";
            var cnxUser = new MySqlConnection(ChaineConnexion);
            try
            {
                cnxUser.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public NewClients()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            var newClient = new ClassClients(0, tbNomClient.Text, tbActivite.Text, tbAdresse.Text, tbVille.Text, Convert.ToInt32(tbCodePostal.Text), tbEmail.Text, tbTelPortable.Text, tbTelFixe.Text, tbSIREN.Text, dtpDateOuverture.Text);



            string reqInsertClient = "INSERT INTO Clients VALUES(";
            
        }
    }
}
