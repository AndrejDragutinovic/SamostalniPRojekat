using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SamostalniPRojekat
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS = "Data Source = DESKTOP-D7QNBFQ\\SQLEXPRESS; Initial Catalog = Prodza; Integrated Security = True";
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
