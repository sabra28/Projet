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


namespace Projet
{
    public partial class AjouterClient : Form
    {
        private MySqlConnection db;

        public AjouterClient()
        {
            InitializeComponent();
            db = new MYDATABASE().GetConnection();
            afficherClient();
            supprimercase();
        }

        private Client ajoutclient = new();

        private void AjouterClient_Load(object sender, EventArgs e)
        {
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            var nomclient = textBoxNom.Text.Trim();
            var prenom = textBoxPrenom.Text.Trim();
            var adresse = textBoxAdresse.Text.Trim();
            var tel = Convert.ToInt32(textBoxTel.Text.Trim());
            ajoutclient.ajouterClient(nomclient, prenom, adresse, tel);
            MessageBox.Show("Client ajouter", "Ajouter client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            afficherClient();
            supprimercase();
        }

        private DataTable getClient()
        {
            var sqlCmd = "SELECT * FROM `client`";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            reader.SelectCommand.CommandType = CommandType.Text;
            var table = new DataTable();
            reader.Fill(table);
            return table;
        }

        private void afficherClient()
        {
            dataGridViewClient.DataSource = getClient();
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ligne = e.RowIndex;
            var id = dataGridViewClient[0, ligne].Value.ToString();
            var nom = dataGridViewClient[1, ligne].Value.ToString();
            var prenom = dataGridViewClient[2, ligne].Value.ToString();
            var adresse = dataGridViewClient[3, ligne].Value.ToString();
            var tel = dataGridViewClient[4, ligne].Value.ToString();


            textBoxIDClient.Text = id;
            textBoxNom.Text = nom;
            textBoxPrenom.Text = prenom;
            textBoxAdresse.Text = adresse;
            textBoxTel.Text = tel;
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxIDClient.Text.Trim());
            var nomclient = textBoxNom.Text.Trim();
            var prenom = textBoxPrenom.Text.Trim();
            var adresse = textBoxAdresse.Text.Trim();
            var tel = Convert.ToInt32(textBoxTel.Text.Trim());
            ajoutclient.modifierClient(ID, nomclient, prenom, adresse, tel);
            MessageBox.Show("Client MODIFIER", "modifier client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            afficherClient();
            supprimercase();
        }

        private void recherherClient(string nom)
        {
            db.Close();
            var table = new DataTable();

            var command =
                new MySqlCommand(
                    "SELECT `id`, `nom`, `prenom`,`adresse`, `tel` FROM `client` WHERE CONCAT(client.id,client.nom) LIKE '%" +
                    nom + "%'", db);
            db.Open();
            var reader = command.ExecuteReader();
            table.Load(reader);
            dataGridViewClient.DataSource = table;
        }

        private void textBoxRechercheClient_TextChanged(object sender, EventArgs e)
        {
            recherherClient(textBoxRechercheClient.Text.Trim());
        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxIDClient.Text.Trim());
            var nomclient = textBoxNom.Text.Trim();
            var prenom = textBoxPrenom.Text.Trim();
            var adresse = textBoxAdresse.Text.Trim();
            var tel = Convert.ToInt32(textBoxTel.Text.Trim());
            ajoutclient.supprimerClient(ID, nomclient, prenom, adresse, tel);
            MessageBox.Show("Client Supprimer", "supprimer client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            afficherClient();
            supprimercase();
        }

        public void supprimercase()
        {
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAdresse.Clear();
            textBoxTel.Clear();
        }
    }
}