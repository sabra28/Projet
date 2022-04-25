using MySql.Data.MySqlClient;
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
    public partial class AjouterProduits : Form
    {
        private MySqlConnection db;

        public AjouterProduits()
        {
            InitializeComponent();
            db = new MYDATABASE().GetConnection();
            afficherPrestation();
            NbPrestations();
        }

        public string numProd { get; set; }
        public bool isUpdate { get; set; }

        private void NbPrestations()
        {
            if (dataGridViewProduit.Rows.Count > 0)
            {
                var nbre = Convert.ToInt32(dataGridViewProduit.Rows.Count);
                if (nbre <= 1)
                    labelnb.Text = "Nombre total de Produit" + dataGridViewProduit.Rows.Count.ToString();
                else
                    labelnb.Text = "nb Total de produit" + dataGridViewProduit.Rows.Count.ToString();
            }
        }

        private AjouterPrestations prestation = new();

        // boutton ajouter produit
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var nomprestation = textBoxPrestation.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var prix = Convert.ToInt32(textBoxPrix.Text.Trim());
            var etat = true;
            if (comboBoxEtat.SelectedIndex == 0)
                etat = true;
            else
                etat = false;
            if (!prestation.verifPrestation(nomprestation))
            {
                //insertion 
                if (prestation.ajouterPrestation(nomprestation, description, prix, etat))
                {
                    MessageBox.Show("Produit ajouter", "Ajouter produit", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    comboBoxEtat.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("erreur", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ce nom exist déja", "Ancien Produit", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }

            afficherPrestation();
        }

        private void AjouterProduits_Load(object sender, EventArgs e)
        {
            comboBoxEtat.SelectedIndex = 0;
        }

        private void chargerProduits()
        {
            var dtprod = GetChargerproduit();

            var row = dtprod.Rows[0];
            textBoxID.Text = row["id"].ToString();
            textBoxPrestation.Text = row["prestation"].ToString();
            textBoxDescription.Text = row["description"].ToString();
            textBoxPrix.Text = Convert.ToInt32(row["prix"]).ToString();
            comboBoxEtat.SelectedValue = row["isActive"].ToString();
        }

        private DataTable GetChargerproduit()
        {
            db.Close();
            var table = new DataTable();
            var comand = new MySqlCommand("SELECT * FROM `prestation` WHERE `id`=@ID", db);
            db.Open();
            comand.Parameters.AddWithValue("@ID", numProd);
            var reader = comand.ExecuteReader();
            table.Load(reader);
            return table;
        }

        //afficher les prestations datagriew
        private void afficherPrestation()
        {
            dataGridViewProduit.DataSource = getPrestation();
        }

        public DataTable getPrestation()
        {
            var sqlCmd = "SELECT * FROM `prestation`";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            reader.SelectCommand.CommandType = CommandType.Text;
            var table = new DataTable();
            reader.Fill(table);
            return table;
        }

        private void recherherPrestations(string prestation)
        {
            db.Close();
            var table = new DataTable();

            var command =
                new MySqlCommand(
                    "SELECT `id`, `prestation`, `description`,`prix`, `isActive` FROM `prestation` WHERE CONCAT(prestation.id,prestation.prestation) LIKE '%" +
                    prestation + "%'", db);
            db.Open();
            var reader = command.ExecuteReader();
            table.Load(reader);
            dataGridViewProduit.DataSource = table;
        }


        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            recherherPrestations(textBoxRecherche.Text.Trim());
        }

        private void textBoxPrestation_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ligne = e.RowIndex;
            var id = dataGridViewProduit[0, ligne].Value.ToString();
            var prestation = dataGridViewProduit[1, ligne].Value.ToString();
            var description = dataGridViewProduit[2, ligne].Value.ToString();
            var prix = dataGridViewProduit[3, ligne].Value.ToString();


            textBoxID.Text = id;
            textBoxPrestation.Text = prestation;
            textBoxDescription.Text = description;
            textBoxPrix.Text = prix;
            comboBoxEtat.SelectedIndex = 0;
        }


        private void buttonModifier_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxID.Text.Trim());
            var nomprestation = textBoxPrestation.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var prix = Convert.ToInt32(textBoxPrix.Text.Trim());
            var etat = true;
            if (comboBoxEtat.SelectedIndex == 0)
                etat = true;
            else
                etat = false;


            //insertion 
            if (prestation.modifierPrestation(ID, nomprestation, description, prix, etat))
            {
                MessageBox.Show("Produit Modifier ajouter", "Modifier produit", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                comboBoxEtat.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("erreur", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            afficherPrestation();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxID.Text.Trim());
            var nomprestation = textBoxPrestation.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var prix = Convert.ToInt32(textBoxPrix.Text.Trim());
            var etat = true;
            if (comboBoxEtat.SelectedIndex == 0)
                etat = true;
            else
                etat = false;


            //insertion 
            if (prestation.supprimerPrestation(ID, nomprestation, description, prix, etat))
            {
                MessageBox.Show("Produit supprimer ajouter", "Modifier produit", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                comboBoxEtat.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("erreur", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            afficherPrestation();
        }
    }
}