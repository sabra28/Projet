using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projet
{
    public class MYDATABASE

    {
        //connection
        private MySqlConnection
            con; // = new MySqlConnection("Server=localhost;User Id =root;password=;Database=gestionstock2");

        public MYDATABASE()
        {
            con = new MySqlConnection("Server=localhost;User Id =root;password=;Database=GestionPrestation");
        }

        public MySqlConnection GetConnection()
        {
            return con;
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Open)

            {
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
    }
}