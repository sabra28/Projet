using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projet
{
    internal class Client
    {
        private MySqlConnection db;

        public Client()
        {
            db = new MYDATABASE().GetConnection();
        }

        public int ajouterClient(string nom, string prenom, string adresse, int tel)
        {
            var command =
                new MySqlCommand(
                    "INSERT INTO `client`( `nom`, `prenom`, `adresse`, `tel`) VALUES (@nom,@prenom,@adresse,@tel)", db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;
            command.Parameters.Add("@tel", MySqlDbType.Int32).Value = tel;
            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }

        public int modifierClient(int id, string nom, string prenom, string adresse, int tel)
        {
            var command =
                new MySqlCommand(
                    "UPDATE `client` SET `nom`=@nom,`prenom`=@prenom,`adresse`=@adresse,`tel`=@tel WHERE `id`=@ID", db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;
            command.Parameters.Add("@tel", MySqlDbType.Int32).Value = tel;

            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }

        public int supprimerClient(int id, string nom, string prenom, string adresse, int tel)
        {
            var command = new MySqlCommand("DELETE FROM `client` WHERE `id`=@ID", db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;
            command.Parameters.Add("@tel", MySqlDbType.Int32).Value = tel;
            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }
    }
}