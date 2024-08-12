using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Clientes_y_Proveedores.Config
{
    internal class ConexionBDD
    {
        //string cadena = "Server = DORIAN; Database = Cuarto clientes; Integrated Security=true";

        //String cade = "Server=.; Database = Cuarto clientes; uid=sa ; Password=12345";
        private SqlConnection con = new SqlConnection("Server=DORIAN; Database = Cuarto clientes; User Id=sa ; Password=12345");

            public SqlConnection AbrirConexion()
            {
            if (con.State == ConnectionState.Closed) 
                con.Open();
                return con;
            }

            public SqlConnection CerrarConexion()
            {
                if (con.State == ConnectionState.Open)
                con.Close();
                return con;
            }
        
    }
}
