using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public UC_Ventas datos;
        public ControladorProductos prodVendido;
        public int cantStock;


        public FormVenta()
        {

            InitializeComponent();
            limpiarErrores();
           // llenarBox();
           // txtPw.Hide();
           // lblPw.Hide();

           // txtID.Text = (ControladorVentas.lastId + 1).ToString();
           // boxClientes.Text = "consumidor final";

        }



        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bool productoValidado = ValidarProducto(out bool errorMsg);

            if (productoValidado)
            {
                cantStock = int.Parse(numCantidad.Text);
                
               
                bool stockValidado = validarStock(out bool errorMssg);
                if(stockValidado)
                { 
                     this.DialogResult = DialogResult.OK;
                }
            }

        }

        /*    public void descontarStock(int cantStock)
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
        */
        public bool validarStock(out bool errorMssg)
        {
            errorMssg = true;
            Producto auxiliar = ControladorProductos.GetProductoByName(SeleccionarProducto.NombreProdComprar);

            if (auxiliar.Stock < cantStock)
            {


                //MessageBox.Show("La cantidad solicitada excede al stock disponible");
                MessageBox.Show("La cantidad solicitada excede al stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorMssg = false;

            }

            return errorMssg;

        }

        private void limpiarErrores()
        {
            errCantidad.Text = "";
          //  errEmpleado.Text = "";
          // errPw.Text = "";
    
            errCantidad.Hide();
           // errEmpleado.Hide();
           // errPw.Hide();

        }
      

        private bool ValidarProducto(out bool errorMsg)
            {
                errorMsg = true;

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

            /*  StreamReader archivo = new StreamReader("usuarios.txt");
              while (!archivo.EndOfStream)
              {
                  string usuario = archivo.ReadLine();
                  string[] datos = usuario.Split(',');

                  if (datos[1].Equals(boxEmpleados.Text) && datos[2] != txtPw.Text)
                  {
                      string error = "Contraseña incorrecta";
                      errPw.Text = error;
                      errPw.Show();
                      errorMsg = false;
                  }
                  else 
                  {
                      errPw.Hide();
                  }


              }
              */



            return errorMsg;
            }


     /*   private void llenarBox()
        {
            List<Cliente> listCte = new List<Cliente>();
            listCte = ControladorClientes.Clientes.Where(x => x.Id != 0).ToList();
            llenarBoxClientes(listCte);

            List<Usuario> listUsu = new List<Usuario>();
            listUsu = controladorUsuarios.Usuarios.Where(x => x.Id != 0).ToList();
            llenarBoxEmpleados(listUsu);
        }

        private void llenarBoxClientes(List<Cliente> listaClientes)
        {
            foreach (Cliente cte in listaClientes)
            {
                if (cte.Vista == true)
                {
                    boxClientes.Items.Add(cte.NUsuario);
                }
            }
        }

        private void llenarBoxEmpleados(List<Usuario> listaUsuarios)
        {
            foreach (Usuario usu in listaUsuarios)
            {
                if (usu.EsAdmin == false)
                {
                    boxEmpleados.Items.Add(usu.Nombre);
                }
            }
        }

        private void liberarContraseña()
        {
            txtPw.Show();
            lblPw.Show();
        }

        private void boxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            liberarContraseña();
        }

        */

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
     