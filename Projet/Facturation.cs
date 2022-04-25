using Aspose.Pdf;
using Aspose.Pdf.Text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Drawing;
using HorizontalAlignment = Aspose.Pdf.HorizontalAlignment;

namespace Projet
{
    public partial class Facturation : Form
    {
        private MySqlConnection db;

        private int _commandeId;


        public Facturation()
        {
            InitializeComponent();
            db = new MYDATABASE().GetConnection();
        }

        private Commande commande = new();
        private AjouterPrestations prestation = new();
        private Facture facture = new();

        public void AfficherCommandes()
        {
            const string sqlCmd =
                "SELECT commande.id , client.nom , commande.date FROM commande , client , ligne , prestation WHERE client.id = commande.idclient AND commande.id = ligne.idcommande and ligne.idprestation = prestation.id GROUP BY commande.id";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            dataGridViewFacture.DataSource = ds.Tables[0];
            db.Close();
        }


        private void Facturation_Load(object sender, EventArgs e)
        {
            AfficherCommandes();
            //Afficherpresta();
        }

        private void dataGridViewFacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AfficherCommandes();
        }

        public void InsererPrixTotalDans(int commandId, DataGridView source)
        {
            var sqlCmd =
                $"SELECT SUM(prestation.prix)FROM prestation, ligne , commande WHERE ligne.idcommande=commande.id and commande.id ={commandId}";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            source.DataSource = ds.Tables[0];
            db.Close();
        }

        public void InsererPrixTotalDans(int commandId, DataGridView source, out double prixTotal)
        {
            var sqlCmd =
                $"SELECT SUM(prestation.prix) as Prix FROM prestation, ligne , commande WHERE ligne.idcommande=commande.id and commande.id ={commandId}";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            source.DataSource = ds.Tables[0];
            db.Close();

            prixTotal = Convert.ToDouble(source.Rows[0].Cells[0].Value);
        }

        public void Afficherpresta(int commandId)
        {
            var sqlCmd =
                $"SELECT commande.id, prestation.prestation , prestation.prix FROM commande , client , ligne , prestation WHERE client.id = commande.idclient AND commande.id = ligne.idcommande and ligne.idprestation = prestation.id and commande.id = {commandId}";
            var reader = new MySqlDataAdapter(sqlCmd, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            db.Close();
        }

        private void dataGridViewFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var commandId = (int) dataGridViewFacture.Rows[e.RowIndex].Cells[0].Value;

            _commandeId = commandId;

            Afficherpresta(commandId);
            InsererPrixTotalDans(commandId, dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On récupère l'ID 

            CreerFacture(_commandeId, db);
        }

        private static void CreerFacture(int commandeId, MySqlConnection db)
        {
            //var commande = CommandeFactory.GetInfoByid(commandeId);
            var clientInformation = CommandeController.GetClientInformationById(commandeId, db);
            var date = PrestationController.GetDateFromDatabaseById(commandeId, db);
            var numero = PrestationController.GetNumeroFromDatabaseById(commandeId, db);

            var document = new Document();
            var page = document.Pages.Add();
            var table = new Table();

            var row = table.Rows.Add();
            // Disalow text wrapping
            row.Cells.Add().Paragraphs.Add(new HtmlFragment($"<h2>Facture n°{numero} </h2><br> <br><br><br>{DefaultPrestationService.RenderDefaultString()}"));
            row.Cells.Add().Paragraphs.Add(new HtmlFragment($"<span></span>"));
            row.Cells.Add().Paragraphs.Add(new HtmlFragment("<span></span>"));
            row.Cells.Add().Paragraphs.Add(new HtmlFragment($"<br>{date}<br> <br><br><br><br><br> {clientInformation}"));
            
            page.Paragraphs.Add(table);

            page.Paragraphs.Add(new HtmlFragment("<br><br><hr>"));
            page.Paragraphs.Add(new HtmlFragment("<h3>QTE                   DESIGNATION                    PRIX 	&nbsp;	&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;	&nbsp;&nbsp;&nbsp;TOTAL </h3>"));
            page.Paragraphs.Add(new HtmlFragment("<hr><br>"));
            // Prestations
            // Display prestations in columns with HtmlFragment
            var prestations = PrestationController.GetPrestationById(commandeId, db);
            



            foreach (var prestation in prestations) page.Paragraphs.Add(new TextFragment($"1                   {prestation}"));
            
            var totalPrice = prestations.Sum(p => int.Parse(p.Prix));

            var totalTable = new Table();
            
            var totalRow = totalTable.Rows.Add();
            
            totalRow.Cells.Add().Paragraphs.Add(new HtmlFragment("<span></span>"));
            totalRow.Cells.Add().Paragraphs.Add(new HtmlFragment("<span></span>"));
            totalRow.Cells.Add().Paragraphs.Add(new HtmlFragment("<span></span>"));
            totalRow.Cells.Add().Paragraphs.Add(new HtmlFragment($"<h3>TOTAL: {totalPrice} €<h3>"));
            
            page.Paragraphs.Add(totalTable);
            
            document.Save($"facture-{clientInformation.Nom}.pdf");

            MessageBox.Show($"Facture créée dans {document.FileName}");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        // SELECT SUM(prestation.prix)FROM prestation, ligne WHERE ligne.idcommande =10
    }

   
    internal static class CommandeController
    {
        public static ClientInformation GetClientInformationById(int commandeId, MySqlConnection db)
        {
            var clientFirstName = GetClientFirstNameFromDatabaseById(commandeId, db);
            var clientName = GetClientNameFromDatabaseById(commandeId, db);
            var clientAdresse = GetClientAdresseFromDatabaseById(commandeId, db);
            var clientTel = GetClientTelFromDatabaseById(commandeId, db);

            return new ClientInformation
            (
                clientFirstName,
                clientName,
                clientAdresse,
                clientTel
            );
        }

        private static string GetClientNameFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT client.nom FROM client,commande where client.id=commande.idclient AND commande.id={commandId}";
            var clientInfo = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return clientInfo;
        }

        private static string GetClientFirstNameFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT client.prenom FROM client,commande where client.id=commande.idclient AND commande.id={commandId}";
            var clientInfo = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return clientInfo;
        }

        private static string GetClientAdresseFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT client.adresse FROM client,commande where client.id=commande.idclient AND commande.id={commandId}";
            var clientInfo = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return clientInfo;
        }

        private static string GetClientTelFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT client.tel FROM client,commande where client.id=commande.idclient AND commande.id={commandId}";
            var clientInfo = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return '0' + clientInfo;
        }
      
    }

    public static class PrestationController
    {
        public static IEnumerable<Prestation> GetPrestationById(int commandeId, MySqlConnection db)
        {
            var title = GetPrestationTitleFromDatabaseById(commandeId, db);
            var price = GetPrestationPriceFromDatabaseById(commandeId, db);

            // Create all prestations then return
            var prestations = new Prestation[title.Length];
            for (var i = 0; i < title.Length; i++) prestations[i] = new Prestation(title[i], price[i]);

            return prestations;
        }
       

        public static string[] GetPrestationTitleFromDatabaseById(int commandeId, MySqlConnection db)
        {
            var query =
                $"SELECT prestation.prestation  FROM commande , client , ligne , prestation WHERE client.id = commande.idclient AND commande.id = ligne.idcommande and ligne.idprestation = prestation.id and commande.id = {commandeId}";
            // Get the possible multiple prestations and return these
            var prestations = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows;
            var prestationTitles = new string[prestations.Count];
            for (var i = 0; i < prestations.Count; i++) prestationTitles[i] = prestations[i].ItemArray[0].ToString();

            return prestationTitles;
        }

        private static string[] GetPrestationPriceFromDatabaseById(int commandeId, MySqlConnection db)
        {
            var query =
                $"SELECT prestation.prix FROM commande , client , ligne , prestation WHERE client.id = commande.idclient AND commande.id = ligne.idcommande and ligne.idprestation = prestation.id and commande.id = {commandeId}";

            // get the possible multiple prestations prices and return these
            var prestations = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows;
            var prestationPrices = new string[prestations.Count];
            for (var i = 0; i < prestations.Count; i++) prestationPrices[i] = prestations[i].ItemArray[0].ToString();

            return prestationPrices;
        }
        public static string GetDateFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT commande.date FROM commande where commande.id={commandId}";

            var date = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return date;
        }
        public static string GetNumeroFromDatabaseById(int commandId, MySqlConnection db)
        {
            var query =
                $"SELECT commande.id FROM commande where commande.id={commandId}";

            var numero = DatabaseFetcherFactory.GetFromDatabase(query, db)[0].Rows[0].ItemArray[0].ToString();

            return numero;
        }

    }

    internal static class DatabaseFetcherFactory
    {
        public static DataTableCollection GetFromDatabase(string query, MySqlConnection db)
        {
            var reader = new MySqlDataAdapter(query, db);
            var cbuilder = new MySqlCommandBuilder(reader);
            var ds = new DataSet();
            reader.Fill(ds);

            return ds.Tables;
        }
    }

    internal record CommandeInformation(ClientInformation ClientInforamtion, string Date, int CommandId, decimal Total,
        string PrestationContent, string PrestationPrix, int Quantite = 1);

    internal record ClientInformation(string Nom, string Prenom, string Adresse, string NumeroTel)
    {
        public override string ToString()
        {
            var stringReprensation = new StringBuilder()
                .AppendLine($"{Nom} {Prenom}")
                .AppendLine($"{Adresse}")
                .AppendLine($"{NumeroTel}");

            return stringReprensation.ToString();
        }
    };

    public record Prestation(string Title, string Prix)
    {
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"{Title} {Prix}€")
                .ToString();
        }
    }

    public record DefaultPrestationService()
    {
        public static string RenderDefaultString()
        {
            return new StringBuilder()
                .AppendLine("Prestation de service")
                .AppendLine("7 rue champs Elysée 75000 Paris")
                .ToString();
        }
    }
}