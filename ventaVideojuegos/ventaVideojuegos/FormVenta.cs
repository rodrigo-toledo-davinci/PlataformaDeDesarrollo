using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Controlers;
using ventaVideojuegos.Modelo;
using ventaVideojuegos.UsersControls;

namespace ventaVideojuegos
{
    public partial class FormVenta : Form
    {
        public Venta ventaNueva;
        public UC_Ventas datos;
        public ControladorProductos prodVendido;
        public int cantStock;


        public FormVenta()
        {

            InitializeComponent();
            limpiarErrores();
            txtID.Text = (ControladorVentas.lastId + 1).ToString();

        }

        private void btnFinalCompra_Click(object sender, EventArgs e)
        {

            bool ventaValidada = ValidarVenta(out bool errorMsg);

            if (ventaValidada)
            {
                ventaNueva = new Venta()
                {
                    Id = int.Parse(txtID.Text),
                    nombreCliente = txtCliente.Text,
                    nombreEmpleado = txtEmpleado.Text,
                    nombreProducto = UC_Ventas.NombreProdComprar,
                    precioProducto = int.Parse(UC_Ventas.PrecioProdComprar),
                    cantidadProducto = int.Parse(numCantidad.Text),   
                    valorTotal = int.Parse(numCantidad.Text) * int.Parse(UC_Ventas.PrecioProdComprar),

                };
                cantStock = int.Parse(numCantidad.Text);
                descontarStock(cantStock);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                //MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.Cancel;
            }

         }

         public void descontarStock(int cantStock)
        {
            Producto auxiliar = ControladorProductos.GetProductoByName(UC_Ventas.NombreProdComprar);
            if (validarStock(auxiliar.Stock, cantStock))
            {
                auxiliar.Stock = auxiliar.Stock - cantStock;
                ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);
            }
            //auxiliar.Stock = auxiliar.Stock - cantStock;
            //ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);

        }

        public bool validarStock(int stock, int cantidad)
        {

            if (cantidad > stock)
            {

                //MessageBox.Show("La cantidad solicitada excede al stock disponible");
                MessageBox.Show("La cantidad solicitada excede al stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;

        }

        private void limpiarErrores()
        {
            errCantidad.Text = "";
            errCliente.Text = "";
            errEmpleado.Text = "";
    
            errCantidad.Hide();
            errCliente.Hide();
            errEmpleado.Hide();

        }

        private bool ValidarVenta(out bool errorMsg)
            {
                errorMsg = true;
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    string error = "Debe ingresar el nombre del cliente";
                    errCliente.Text = error;
                    errCliente.Show();
                    errorMsg = false;
                }
                else
                {
                    errCliente.Hide();
                }
                if (string.IsNullOrEmpty(txtEmpleado.Text))
                {
                    string error = "Debe ingresar el nombre del empleado";
                    errEmpleado.Text = error;
                    errEmpleado.Show();
                    errorMsg = false;
                }
                else
                {
                    errEmpleado.Hide();
                }


                if (int.Parse(numCantidad.Text) <= 0)
                {

                    string error = "Debe ingresar la cantidad deseada";
                    errCantidad.Text = error;
                    errCantidad.Show();
                    errorMsg = false;
                }
                else
                {
                    errCantidad.Hide();
                }
       
            return errorMsg;
            }

      
        }
}
     