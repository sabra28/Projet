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
    public partial class AjouterCommande : Form
    {
        private MySqlConnection db;

        public AjouterCommande()
        {
            InitializeComponent();
            db = new MYDATABASE().GetConnection();
        }

        private DateTime today;
        private Commande commande = new();
        private AjouterPrestations prestation = new();


        private void AjuterCommande_Load(object sender, EventArgs e)
        {
            fillClientCombo();
            today = dateTimePicker.Value;
            AfficherCommande();
            AfficherPrestation();

            dataGridViewPrestation.ColumnCount = 2;
            dataGridViewPrestation.Columns[0].Name = "Id";
            dataGridViewPrestation.Columns[1].Name = "Prestation";
        }

        public void fillClientCombo()
        {
            db.Open();
            var command = new MySqlCommand("SELECT `id`,`nom` FROM `client`", db);
            MySqlDataReader rdr;
            rdr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Columns.Add("nom", typeof(string));
            dt.Load(rdr);
            comboBoxNomClient.DisplayMember = "nom";
            comboBoxNomClient.ValueMember = "id";
            comboBoxNomClient.DataSource = dt;
            db.Close();
        }

        private void comboBoxPrestation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AfficherCommande()
        {
            var sqlCmd =
                "SELECT commande.id ,commande.date,client.nom FROM commande INNER JOIN client ON commande.idclient = client.id";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            dataGridViewCommande.DataSource = ds.Tables[0];
            db.Close();
        }

        private void buttonAjouterCommande_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker.Value.Date;
            var idcli = Convert.ToInt32(comboBoxNomClient.SelectedValue.ToString());
            commande.ajouterCommande(date, idcli);
            AfficherCommande();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonSupCommande_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxIDCommande.Text.Trim());
            var date = dateTimePicker.Value.Date;
            var idcli = Convert.ToInt32(comboBoxNomClient.SelectedValue.ToString());
            commande.supprimerCommande(ID, date, idcli);
            AfficherCommande();
        }

        private void dataGridViewCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ligne = e.RowIndex;
            var id = dataGridViewCommande[0, ligne].Value.ToString();
            var date = dataGridViewCommande[1, ligne].Value.ToString();
            var nom = dataGridViewCommande[2, ligne].Value.ToString();


            textBoxIDCommande.Text = id;
            dateTimePicker.Text = date;
            comboBoxNomClient.SelectedIndex = comboBoxNomClient.FindStringExact(nom);
        }

        private void dataGridViewCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void AfficherPrestation()
        {
            var sqlCmd = "SELECT id,prestation FROM `prestation`";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            dataGridViewPresta.DataSource = ds.Tables[0];
            db.Close();
        }

        private void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(textBoxIDCommande.Text.Trim());
            var date = dateTimePicker.Value.Date;
            var idcli = Convert.ToInt32(comboBoxNomClient.SelectedValue.ToString());
            commande.modifierCommande(ID, date, idcli);
            AfficherCommande();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewPrestation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var idPestation = dataGridViewPresta.Rows[dataGridViewPresta.CurrentCell.RowIndex].Cells[0].Value
                .ToString();
            var prestation = dataGridViewPresta.Rows[dataGridViewPresta.CurrentCell.RowIndex].Cells[1].Value.ToString();
            dataGridViewPrestation.Rows.Add(idPestation, prestation);
        }

        private void Entrer_Click(object sender, EventArgs e)
        {
            var idcommande = dataGridViewCommande.Rows[dataGridViewCommande.CurrentCell.RowIndex].Cells[0].Value
                .ToString();

            for (var x = 0; x < dataGridViewPrestation.Rows.Count - 1; x++)
            {
                var idPrestation = dataGridViewPrestation.Rows[x].Cells[0].Value.ToString();
                commande.ajouterLigne(int.Parse(idPrestation), int.Parse(idcommande));
            }
            
        }


        private void recapfacture_Click(object sender, EventArgs e)
        {
            var facture = new Facturation();
            facture.ShowDialog();
        }
    }
}