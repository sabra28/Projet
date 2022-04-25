using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrestation_Click(object sender, EventArgs e)
        {
            var ajoutprod = new AjouterProduits();
            ajoutprod.ShowDialog();
        }

        private void buttonCient_Click(object sender, EventArgs e)
        {
            var ajoutcl = new AjouterClient();
            ajoutcl.ShowDialog();
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            var commande = new AjouterCommande();
            commande.ShowDialog();
        }

        private void Facture_Click(object sender, EventArgs e)
        {
            var facture = new Facturation();
            facture.ShowDialog();
        }
    }
}