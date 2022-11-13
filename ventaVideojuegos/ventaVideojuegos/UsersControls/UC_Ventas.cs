using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos;
using ventaVideojuegos.Controlers;
using ventaVideojuegos.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ventaVideojuegos.UsersControls
{
    public partial class UC_Ventas : UserControl
    {

       public FormValidarVenta datos;
        public Venta ventaNueva;
        public static string NombreProdComprar;
        public static string PrecioProdComprar;
        public static string StockProdComprar;
        public static int precioParcial;
        public static int precioVenta = 0;
        public static int restar;




        public UC_Ventas()
        {
            InitializeComponent();
            ControladorVentas.IniciarRepositorio();
            lblValor.Text = precioVenta.ToString();
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
            SeleccionarProducto formSelecProd = new SeleccionarProducto();
            DialogResult dialogResult = formSelecProd.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value =  SeleccionarProducto.NombreProdComprar.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = SeleccionarProducto.PrecioProdComprar.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = SeleccionarProducto.StockProdComprar.ToString();
                precioParcial = int.Parse(SeleccionarProducto.StockProdComprar) * int.Parse(SeleccionarProducto.PrecioProdComprar);
                dataGridView1.Rows[rowIndex].Cells[3].Value = precioParcial.ToString();


                NombreProdComprar = SeleccionarProducto.NombreProdComprar.ToString();
                PrecioProdComprar = SeleccionarProducto.StockProdComprar.ToString();
                StockProdComprar = SeleccionarProducto.PrecioProdComprar.ToString();

                precioVenta = precioVenta + precioParcial;
               
                lblValor.Text = precioVenta.ToString();
               

                

             }


        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

            dataGridView1.AllowUserToAddRows = false;

            if (dataGridView1.Rows.Count > 0)
            {
                FormValidarVenta formVenta = new FormValidarVenta();
                DialogResult dialogResult = formVenta.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        ventaNueva = new Venta
                        {
                            Id = formVenta.stockk,
                            nombreCliente = formVenta.cliente,
                            nombreEmpleado = formVenta.empleado,
                            nombreProducto = row.Cells["Producto"].Value.ToString(),
                            precioProducto = int.Parse(row.Cells["Precio"].Value.ToString()),
                            cantidadProducto = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                            valorTotal = int.Parse(row.Cells["Total"].Value.ToString()),
                            DateTime = DateTime.Now,

                            };
                            ControladorVentas.AñadirVenta(ventaNueva);
                            descontarStock(int.Parse(row.Cells["Cantidad"].Value.ToString()), row.Cells["Producto"].Value.ToString());
                        
                    }
                    precioVenta = 0;
                    lblValor.Text = precioVenta.ToString();
                    dataGridView1.Rows.Clear();
                    dataGridView1.AllowUserToAddRows = true;

                }

            }
            else
            {
                MessageBox.Show("El carrito se encuentra vacío", "Error", MessageBoxButtons.OK);
            }
            
        }

       public void descontarStock(int cantStock, string nameProd)
       {
           Producto auxiliar = ControladorProductos.GetProductoByName(nameProd);
           if (auxiliar.Stock > cantStock)
           {
               auxiliar.Stock = auxiliar.Stock - cantStock;
               ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);
           }
           //auxiliar.Stock = auxiliar.Stock - cantStock;
           //ControladorProductos.ActualizarProductos(auxiliar.Id, auxiliar);

       }


        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 )
            {
                int precioDescontar = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                
                precioVenta = precioVenta - precioDescontar;
                lblValor.Text = precioVenta.ToString();

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para quitar del carrito", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            precioVenta = 0;
            lblValor.Text = precioVenta.ToString();
            dataGridView1.Rows.Clear();
        }

        private void editarCant_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                FormVenta formEditVenta = new FormVenta();
                DialogResult dialogResult = formEditVenta.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {

                     string editStockProdComprar = formEditVenta.cantStock.ToString();

                    dataGridView1.SelectedRows[0].Cells[0].Value = SeleccionarProducto.NombreProdComprar.ToString();
                    dataGridView1.SelectedRows[0].Cells[1].Value = SeleccionarProducto.PrecioProdComprar.ToString();
                    dataGridView1.SelectedRows[0].Cells[2].Value = editStockProdComprar.ToString();
                    precioParcial = int.Parse(editStockProdComprar) * int.Parse(SeleccionarProducto.PrecioProdComprar);
                    dataGridView1.SelectedRows[0].Cells[3].Value = precioParcial.ToString();


                    NombreProdComprar = SeleccionarProducto.NombreProdComprar.ToString();
                    PrecioProdComprar = SeleccionarProducto.StockProdComprar.ToString();
                    StockProdComprar = editStockProdComprar.ToString();

                    precioVenta = precioVenta + precioParcial;

                    lblValor.Text = precioVenta.ToString();


                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto editar", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
            
