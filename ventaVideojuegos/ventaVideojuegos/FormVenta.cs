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
        public UC_Ventas ventita;
        public FormVenta()
        {
            InitializeComponent();
            
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
                    //  nombreProducto = U_dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    nombreProducto = UC_Ventas.nombreProdCompra,
                    cantidadProducto = int.Parse(numCantidad.Text),
                    precioProducto = UC_Ventas.precioProdCompra,
                    valorTotal = int.Parse(numCantidad.Text) * UC_Ventas.precioProdCompra

                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
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
            return errorMsg == String.Empty;
        }
    }
}
