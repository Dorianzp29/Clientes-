using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Clientes_y_Proveedores.Config;
namespace Clientes_y_Proveedores.Models
{
    internal class ClientesProveedoresModel
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }

        public string DisplayName
        {
            get
            {
                  return Nombre + " " + Apellido + " " + Direccion + " " + Telefono + " " + Cedula + " " + Correo;
            }
        }
        private ConexionBDD conexionBDD = new ConexionBDD();

        SqlDataReader lector;
        List<ClientesProveedoresModel> listaClientes = new List<ClientesProveedoresModel>(); 
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public List<ClientesProveedoresModel> Todos()
        {
            string cadena = "SELECT * FROM Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow fila in data.Rows)
            {
                ClientesProveedoresModel cliente = new ClientesProveedoresModel
                {
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    Direccion = fila["Dirección"].ToString(),
                    Telefono = fila["Teléfono"].ToString(),
                    Cedula = fila["Cédula"].ToString(),
                    Correo = fila["Correo"].ToString()
                };
                listaClientes.Add(cliente);
            }

            conexionBDD.CerrarConexion();
            return listaClientes;
        }


        public void agregar()
        {            
                cmd.Connection = conexionBDD.AbrirConexion();
                string cadena = "INSERT INTO Clientes (Nombre, Apellido, Dirección, Teléfono, Cédula, Correo) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Cedula, @Correo)";
                using (SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Correo", Correo);
                    cmd.ExecuteNonQuery();
                    conexionBDD.CerrarConexion();
                }
            }              
      
        


        public void Actualizar()
        {

            string cadena = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono, Cedula = @Cedula, Correo = @Correo WHERE IDCliente = @IDCliente";
            using (SqlCommand comando = new SqlCommand(cadena, conexionBDD.AbrirConexion()))
            {
                comando.Parameters.AddWithValue("@IDCliente", IDCliente);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Cedula", Cedula);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.ExecuteNonQuery();
                conexionBDD.CerrarConexion();
            }
            
        }

        public void Eliminar(int id)
        {
            string cadena = "DELETE FROM Clientes WHERE IDCliente = @IDCliente";
            using (SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@IDCliente", id);
                cmd.ExecuteNonQuery();
                conexionBDD.CerrarConexion();
            }
                    
                    
                    
                    
                    
         }
    }
}
