using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projet
{
    internal class AjouterPrestations
    {
        private MySqlConnection db;

        public AjouterPrestations()
        {
            db = new MYDATABASE().GetConnection();
        }

        //creation de la function d'ajout en stock 
        public bool ajouterPrestation(string prestation, string description, int prix, bool etat)
        {
            var command =
                new MySqlCommand(
                    "INSERT INTO `prestation`( `prestation`, `description`, `prix`, `isActive`) VALUES (@prestation,@description,@prix,@etat)",
                    db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@prestation", MySqlDbType.VarChar).Value = prestation;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@prix", MySqlDbType.Int32).Value = prix;
            command.Parameters.Add("@etat", MySqlDbType.Bit).Value = etat;
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

        public bool supprimerPrestation(int id, string prestation, string description, int prix, bool etat)
        {
            var command = new MySqlCommand(" DELETE FROM `prestation` WHERE `id`=@ID", db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@prestation", MySqlDbType.VarChar).Value = prestation;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@prix", MySqlDbType.Int32).Value = prix;
            command.Parameters.Add("@etat", MySqlDbType.Bit).Value = etat;
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


        //modifier 
        public bool modifierPrestation(int id, string prestation, string description, int prix, bool etat)
        {
            var command =
                new MySqlCommand(
                    "UPDATE `prestation` SET `prestation`=@prestation,`description`=@description,`prix`=@prix,`isActive`=@etat WHERE `id`=@ID",
                    db);
            //@design,@prix,@qte,@etat
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@prestation", MySqlDbType.VarChar).Value = prestation;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            command.Parameters.Add("@prix", MySqlDbType.Int32).Value = prix;
            command.Parameters.Add("@etat", MySqlDbType.Bit).Value = etat;
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


        //verification d'un produit
        public bool verifPrestation(string nomprestation)
        {
            var command = new MySqlCommand("SELECT * FROM `prestation` WHERE `prestation`=@prestation", db);
            command.Parameters.Add("@prestation", MySqlDbType.VarChar).Value = nomprestation;
            var adapter = new MySqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
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
    }
}