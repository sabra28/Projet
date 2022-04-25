using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Commande
    {
        private MySqlConnection db;

        public Commande()
        {
            db = new MYDATABASE().GetConnection();
        }

        public int ajouterCommande(DateTime date, int idclient)
        {
            var command = new MySqlCommand("INSERT INTO `commande` (`date`, `idclient`) VALUES (@date,@idcli)", db);

            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@idcli", MySqlDbType.Int32).Value = idclient;

            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }

        public bool supprimerCommande(int id, DateTime date, int idclient)
        {
            var command = new MySqlCommand(" DELETE FROM `commande` WHERE `id`=@ID", db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@idcli", MySqlDbType.Int32).Value = idclient;
            db.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                db.Close();
                return true;
            }
            else
            {
                db.Close();
                return false;
            }
        }


        public int modifierCommande(int id, DateTime date, int idclient)
        {
            var command = new MySqlCommand("UPDATE `commande` SET `date`=@date,`idclient`=@idclient WHERE `id`=@ID",
                db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@idclient", MySqlDbType.Int32).Value = idclient;

            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }

        public int ajouterLigne(int idprestation, int idcommande)
        {
            var command =
                new MySqlCommand("INSERT INTO `ligne` ( `idprestation`,`idcommande`) VALUES (@idpresta,@idcom)", db);

            command.Parameters.Add("@idpresta", MySqlDbType.Int32).Value = idprestation;
            command.Parameters.Add("@idcom", MySqlDbType.Int32).Value = idcommande;

            db.Open();
            var resultat = Convert.ToInt32(command.ExecuteNonQuery());
            db.Close();
            return resultat;
        }
    }
}