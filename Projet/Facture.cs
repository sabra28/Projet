using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Facture
    {
        private MySqlConnection db;

        public Facture()
        {
            db = new MYDATABASE().GetConnection();
        }
    }
}