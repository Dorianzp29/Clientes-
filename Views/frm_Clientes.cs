using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes_y_Proveedores.Controllers;
using Clientes_y_Proveedores.Models;
namespace Clientes_y_Proveedores
{
    public partial class frm_Clientes : Form
    {
        ClienteController clienteController = new ClienteController();
        string IDCliente;
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            cargarLista();
        }


        public void cargarLista()
        {
            lstClientes.DataSource = clienteController.todos();
            lstClientes.DisplayMember = "DisplayName" ;
            lstClientes.ValueMember = "IDCliente";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                ClientesProveedoresModel clienteSeleccionado = (ClientesProveedoresModel)lstClientes.SelectedItem;
                clienteSeleccionado.Nombre = txt_NombreCl.Text;
                clienteSeleccionado.Apellido = txt_ApeCl.Text;
                clienteSeleccionado.Direccion = txt_DireccCl.Text;
                clienteSeleccionado.Telefono = txt_TelefCl.Text;
                clienteSeleccionado.Cedula = txt_CeduCl.Text;
                clienteSeleccionado.Correo = txt_CorreoCl.Text;

                ClienteController clienteController = new ClienteController();
                try
                {
                    clienteController.actualizar(clienteSeleccionado);
                    MessageBox.Show("Cliente actualizado correctamente.");
                    cargarLista(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
            }
        }

        

        void btn_Grabar_Click(object sender, EventArgs e)
        {
            
            ClientesProveedoresModel Cliente = new ClientesProveedoresModel
            {
                IDCliente = Convert.ToInt32(lstClientes.SelectedValue),
                Nombre = txt_NombreCl.Text,
                Apellido = txt_ApeCl.Text,
                Direccion = txt_DireccCl.Text,
                Telefono = txt_TelefCl.Text,
                Cedula = txt_CeduCl.Text,
                Correo = txt_CorreoCl.Text
            };

            ClienteController clienteController = new ClienteController();
            try
            {
                clienteController.agregar(Cliente);
                MessageBox.Show("Cliente agregado correctamente.");
                cargarLista(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        
    }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                ClientesProveedoresModel clienteSeleccionado = (ClientesProveedoresModel)lstClientes.SelectedItem;
                ClienteController clienteController = new ClienteController();
                try
                {
                    clienteController.eliminar(clienteSeleccionado.IDCliente);
                    MessageBox.Show("Cliente eliminado correctamente.");
                    cargarLista(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
            }
        }

        
        
        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                ClientesProveedoresModel clienteSeleccionado = (ClientesProveedoresModel)lstClientes.SelectedItem;
                IDCliente = clienteSeleccionado.IDCliente.ToString();
                txt_NombreCl.Text = clienteSeleccionado.Nombre;
                txt_ApeCl.Text = clienteSeleccionado.Apellido;
                txt_DireccCl.Text = clienteSeleccionado.Direccion;
                txt_TelefCl.Text = clienteSeleccionado.Telefono;
                txt_CeduCl.Text = clienteSeleccionado.Cedula;
                txt_CorreoCl.Text = clienteSeleccionado.Correo;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.");
            }
        }
    }
}
