using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos;
using ventaVideojuegos.Controlers;
using ventaVideojuegos.Modelo;

namespace ventaVideojuegos.UsersControls
{
    public partial class UC_Ventas : UserControl
    {
        private static Producto filtro = new Producto();
        private List<Producto> Productos_Completo = new List<Producto>();
        private List<Producto> Productos_Filtrado = new List<Producto>();
        private List<Producto> Productos_Paginados = new List<Producto>();

        private static int current = 0;
        private static int paginador = 10;
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;

        public static string NombreProdComprar;
        public static string PrecioProdComprar;
        public static string StockProdComprar;

        public UC_Ventas()
        {
            InitializeComponent();
            ControladorCategorias.IniciarRepositorio();
            ControladorConsola.IniciarRepositorio();
            ControladorProductos.IniciarRepositorio();
            ControladorVentas.IniciarRepositorio();
            Productos_Completo = ControladorProductos.Productos;
            Productos_Completo = ControladorProductos.Productos;
            Productos_Filtrado = ControladorProductos.Productos;
            total = Productos_Completo.Count(prod => prod.Vista == true);
            last_pag = total / paginador;
            llenarCombos();
            VisualizarProductos(Productos_Completo);
            paginar(Productos_Completo);


        }

        private void VisualizarProductos(List<Producto> listaProductos)
        {
            dataGridView1.Rows.Clear();
            foreach (Producto prod in listaProductos)
            {
                if (prod.Vista == true && prod.Stock > 0)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Precio.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Categoria.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Consola.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Conexion.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = prod.ModoJuego.ToString();
                    // Bitmap img;
                    // img = new Bitmap("RUTA" + prod.Imagen + ".jpg");
                    // dataGridView1.Rows[rowIndex].Cells[8].Value = img;
         
                }
            }
        }





        private void filtrar()
        {
            // Productos_Filtrado = Productos_Completo;

            if (filtro.Nombre != null)
            {
                Productos_Filtrado = Productos_Completo.Where(x => x.Nombre.ToLower().Contains(filtro.Nombre)).ToList();


            }

            if (filtro.Categoria != null)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Categoria == filtro.Categoria).ToList();
            }



            if (filtro.Consola != null)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Consola == filtro.Consola).ToList();
            }

            total = Productos_Filtrado.Count();
            last_pag = (total / paginador) + 1;
            current = 0;
            current_pag = 1;

            paginar(Productos_Filtrado);

        }

        private void paginar(List<Producto> prodMostrar)
        {
            Productos_Paginados = prodMostrar.Skip(current).Take(paginador).ToList();
            VisualizarProductos(Productos_Paginados);
           

            if (current_pag == 1)
            {
                btn_FirstPage.Hide();
                btn_prev_page.Hide();

            }
            else
            {
                btn_FirstPage.Show();
                btn_FirstPage.Text = "1";
                btn_prev_page.Show();
                btn_prev_page.Text = (current_pag - 1).ToString();
            }

            if (current_pag == last_pag)
            {
                btn_last_page.Hide();
                btn_next_page.Hide();
            }
            else
            {
                btn_last_page.Show();
                btn_next_page.Show();
            }

            if (btn_FirstPage.Text == btn_prev_page.Text)
            {
                btn_FirstPage.Hide();
            }

            if (btn_last_page.Text == btn_next_page.Text)
            {
                btn_last_page.Hide();
            }

            btn_next_page.Text = (current_pag + 1).ToString();
            btn_prev_page.Text = (current_pag - 1).ToString();
            btn_actual_page.Text = (current_pag).ToString();

        }

        private void llenarCombos()
        {
            List<Categoria> listCat = new List<Categoria>();
            listCat = ControladorCategorias.Categorias.Where(x => x.Id != 0).ToList();
            llenarBoxCategorias(listCat);
            List<Consola> listCon = new List<Consola>();
            listCon = ControladorConsola.Consolas.Where(x => x.Id != 0).ToList();

            llenarBoxConsolas(listCon);
        }

        private void llenarBoxConsolas(List<Consola> listaConsolas)
        {
            foreach (Consola con in listaConsolas)
            {
                if (con.Vista == true)
                {
                    boxConsolas.Items.Add(con.Nombre);
                }
            }
        }

        private void llenarBoxCategorias(List<Categoria> listaCategorias)
        {
            foreach (Categoria cat in listaCategorias)
            {
                if (cat.Vista == true)
                {
                    boxCategorias.Items.Add(cat.Nombre);
                }
            }
        }

        private void filtroNombre_TextChanged_1(object sender, EventArgs e)
        {
            string nombreFiltrar = filtroNombre.Text.ToString().ToLower();

            if (string.IsNullOrEmpty(filtroNombre.Text))
            {
                filtro.Nombre = null;
            }
            else
            {
                filtro.Nombre = nombreFiltrar;
                filtrar();
            }
        }

        private void boxCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (boxCategorias.SelectedItem != null)
            {
                Categoria seleccionado = ControladorCategorias.GetCategoriaByName(boxCategorias.SelectedItem.ToString());
                filtro.Categoria = seleccionado;
                lblCat.Text = seleccionado.Nombre;
                filtrar();
            }
        }

        private void boxConsolas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (boxConsolas.SelectedItem != null)
            {
                Consola seleccionado = ControladorConsola.GetConsolaByName(boxConsolas.SelectedItem.ToString());
                filtro.Consola = seleccionado;
                lblCon.Text = seleccionado.Nombre;
                filtrar();
            }
        }

        private void btnVaciarFiltros_Click_1(object sender, EventArgs e)
        {

            boxCategorias.SelectedItem = null;
            boxConsolas.SelectedItem = null;
            filtroNombre.Text = null;

            filtro.Nombre = null;
            filtro.Categoria = null;
            filtro.Consola = null;

            lblCon.Text = "Consola";
            lblCat.Text = "Categoria";

            Productos_Filtrado = Productos_Completo;

            paginar(Productos_Completo);
            btn_last_page.Show();
            btn_next_page.Show();
        }

        private void btn_FirstPage_Click_1(object sender, EventArgs e)
        {
            current = 0;
            current_pag = 1;
            paginar(Productos_Filtrado);
            btn_actual_page.Text = current_pag.ToString();
        }

        private void btn_prev_page_Click_1(object sender, EventArgs e)
        {
            current = current - paginador;
            current_pag = (current_pag - 1);
            btn_actual_page.Text = current_pag.ToString();

            paginar(Productos_Filtrado);
        }

        private void btn_next_page_Click_1(object sender, EventArgs e)
        {

            current = current + paginador;
            current_pag = (current_pag + 1);
            btn_actual_page.Text = current_pag.ToString();
            paginar(Productos_Filtrado);
        }

        private void btn_last_page_Click_1(object sender, EventArgs e)
        {
            current = last_pag + paginador;
            current_pag = last_pag;
            btn_actual_page.Text = current_pag.ToString();
            paginar(Productos_Filtrado);
        }

        private void btnAñadirCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NombreProdComprar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PrecioProdComprar= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                StockProdComprar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                FormVenta formCantVenta = new FormVenta();
                DialogResult dialogResult = formCantVenta.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {

                    ControladorVentas.AñadirVenta(formCantVenta.ventaNueva);
                }



            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para comprar", "Error", MessageBoxButtons.OK);
            }

        }

    }
}
            
