using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Assert = NUnit.Framework.Assert;

namespace Projet.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private MySqlConnection _db;

        public UnitTest1()
        {
            _db = new MySqlConnection("Server=localhost;Database=GestionPrestation;Uid=root;Pwd=;");
        }

        [TestMethod]
        public void DefaultPrestationServiceNeDoitPasEtreNull()
        {
            Assert.NotNull(DefaultPrestationService.RenderDefaultString());
            Assert.AreSame(typeof(string), DefaultPrestationService.RenderDefaultString().GetType());
        }

        [TestMethod]
        public void PrestationDoitAvoirbonToString()
        {
            var prestation = new Prestation
            (
                "Titre",
                "12"
            );

            var expected = "Titre 12€\r\n";

            Assert.AreEqual(expected, prestation.ToString());
        }

        [TestMethod]
        public void PrestationNomDoitEtreBonAvecCommande11()
        {
            var prestationTitre = PrestationController.GetPrestationTitleFromDatabaseById(11, _db);

            var expected = new string[] { "chargeur" };

            Assert.NotNull(prestationTitre);

            Assert.AreEqual(expected, prestationTitre);
        }
    }
}