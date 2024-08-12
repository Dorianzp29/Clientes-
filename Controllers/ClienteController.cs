using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clientes_y_Proveedores.Models;
namespace Clientes_y_Proveedores.Controllers
{
    internal class ClienteController
    {
        private ClientesProveedoresModel clientesProveedoresModel = new ClientesProveedoresModel();

        public List<ClientesProveedoresModel> todos()
        {
            List<ClientesProveedoresModel> listaCliente = new List<ClientesProveedoresModel>();
            listaCliente = clientesProveedoresModel.Todos();
            return listaCliente;
        }

        public void agregar(ClientesProveedoresModel Cliente)
        {
            Cliente.agregar();
        }

        public void actualizar(ClientesProveedoresModel Cliente)
        {
            Cliente.Actualizar();
        }

        public void eliminar(int id)
        {
            clientesProveedoresModel.Eliminar(id);
        }
    }
}
