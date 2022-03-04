using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Gestion_Commerciale
{
    class ADO
    {
        //declaration des objets sql
        public SqlConnection cnx = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        //declaration methode connecter
        public void Connecter()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.ConnectionString = "Data Source=LAPTOP-SCDE1S5U\\SQLEXPRESS01;Initial Catalog=stock;Integrated Security=True";
                cnx.Open();
            }
        }
        //declaration methode deconnecter
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
