﻿using System;
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
        public Venta ventaNueva;
        public UC_Ventas datos;
        public ControladorProductos prodVendido;
        public int cantStock;


        public FormVenta()
        {

            InitializeComponent();
            limpiarErrores();
            llenarBox();
            txtPw.Hide();
            lblPw.Hide();

            txtID.Text = (ControladorVentas.lastId + 1).ToString();
            boxClientes.Text = "cliente comun";

        }

        private void btnFinalCompra_Click(object sender, EventArgs e)
        {

            bool ventaValidada = ValidarVenta(out bool errorMsg);

            if (ventaValidada)
            {
                ventaNueva = new Venta()
                {
                    Id = int.Parse(txtID.Text),
                    nombreCliente = boxClientes.Text,
                    nombreEmpleado = boxEmpleados.Text,
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
            errEmpleado.Text = "";
            errPw.Text = "";
    
            errCantidad.Hide();
            errEmpleado.Hide();
            errPw.Hide();

        }

        private bool ValidarVenta(out bool errorMsg)
            {
                errorMsg = true;

                if (string.IsNullOrEmpty(boxEmpleados.Text))
                {
                    string error = "Debe seleccionar el vendedor";
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

                StreamReader archivo = new StreamReader("usuarios.txt");
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




            return errorMsg;
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void llenarBox()
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
    }
}
     