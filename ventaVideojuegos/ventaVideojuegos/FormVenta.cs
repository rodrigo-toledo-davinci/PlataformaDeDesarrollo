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

            txtID.Text = (ControladorVentas.lastId + 1).ToString();

        }

        private void btnFinalCompra_Click(object sender, EventArgs e)
        {

            bool ventaValidada = ValidarVenta(out string errorMsg);

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
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Hide();
         }

         public void descontarStock(int cantStock)
        {
            Producto auxiliar = ControladorProductos.GetProductoByName(UC_Ventas.NombreProdComprar);
            auxiliar.Stock = auxiliar.Stock - cantStock;
            ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);
           

        }
       
        private bool ValidarVenta(out string errorMsg)
            {
                errorMsg = String.Empty;
                if (string.IsNullOrEmpty(txtEmpleado.Text))
                {
                    errorMsg += "Debe indicar el Nombre del empleado" + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    errorMsg += "Debe indicar el Nombre del cliente" + Environment.NewLine;
                }

                if (string.IsNullOrEmpty(numCantidad.Text))
                {
                    errorMsg += "Debe indicar la cantidad de productos" + Environment.NewLine;
                }

                if (int.Parse(numCantidad.Text) <= 0)
                {
                    errorMsg += "Cantidad incorrecta" + Environment.NewLine;
                }
            return errorMsg == String.Empty;
            }

      
        }
}
     