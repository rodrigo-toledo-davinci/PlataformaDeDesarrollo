using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Modelo;

namespace ventaVideojuegos.UsersControls
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }

        private void VisualizarProductos()
        {
            dataGridView1.Rows.Clear();
            foreach (Producto prod in ControladorProductos.Productos)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Precio.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Stock.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Categoria.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Consola.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = prod.Conexion.ToString();
                dataGridView1.Rows[rowIndex].Cells[7].Value = prod.ModoJuego.ToString();
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idCategoriaEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ControladorProductos.EliminarProducto(int.Parse(idCategoriaEliminar));
                VisualizarProductos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Eliminar", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProdEditar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreProdEditar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string PrecioProdEditar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string StockProdEditar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string CategoriaProdEditar = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string ConsolaProdEditar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string ConexionProdEditar = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string ModoJuegoProdEditar = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                Producto productoEditar = new Producto()
                {
                    Id = int.Parse(idProdEditar),
                    Nombre = nombreProdEditar,
                    Precio = int.Parse(PrecioProdEditar),
                    Stock = int.Parse(StockProdEditar),
                    Categoria = ControladorCategorias.GetCategoriaByName(CategoriaProdEditar),
                    Consola = ControladorConsola.GetConsolaByName(CategoriaProdEditar),
                    Conexion = ConexionProdEditar,
                    ModoJuego = ModoJuegoProdEditar
                };

                FormProducto productForm = new FormProducto(productoEditar);
                DialogResult dialogResult = productForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ControladorProductos.ActualizarProductos(int.Parse(idProdEditar), productForm.productoNuevo);
                    VisualizarProductos();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para Editar", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormProducto productForm = new FormProducto();
            DialogResult dialogResult = productForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ControladorProductos.AñandirProducto(productForm.productoNuevo);
                VisualizarProductos();
            }
        }

    }
}
