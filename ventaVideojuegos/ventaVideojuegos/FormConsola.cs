using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventaVideojuegos.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ventaVideojuegos
{
    public partial class FormConsola : Form
    {

        public Consola consolaNueva;
        public FormConsola()
        {
            InitializeComponent();
            limpiarErrores();
            llenarBoxEstado();
            txtID.Text = (ControladorConsola.lastId + 1).ToString();
            boxEstado.Text = "True";
        }
        
        public FormConsola(Consola con)
        {
            InitializeComponent();
            limpiarErrores();
            llenarBoxEstado();
            txtID.Text = con.Id.ToString();
            txtNombre.Text = con.Nombre.ToString();
            boxEstado.Text = con.Vista.ToString();
        }
        // este no se utiliza porque el id se pasa en uc_admin en el metodo "dataGridViewCon2_CellContentClick()"  
        public FormConsola(int idd)
        {
            InitializeComponent();
            limpiarErrores();
            llenarBoxEstado();

            conexion.Conectar();
            string query = "use tienda; select * from Consola where IdConsola="+idd;
            SqlCommand cmd = new SqlCommand(query,conexion.Conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                txtID.Text = Convert.ToString(reader["IdConsola"]);
                txtNombre.Text = Convert.ToString(reader["Nombre"]);
                boxEstado.Text = Convert.ToString(reader["Visible"]);
            }
            

            /*
            conexion.Conectar();
            string consulta1 = "use tienda; select Nombre from Consola where IdConsola=@id;";
            SqlCommand cmd1 = new SqlCommand(consulta1, conexion.Conectar());
            cmd1.Parameters.AddWithValue("@id", idd);     
            string nombre = cmd1.ExecuteScalar().ToString();

            string consulta2 = "use tienda; select Visible from Consola where IdConsola=@id;";
            SqlCommand cmd2 = new SqlCommand(consulta2, conexion.Conectar());
            cmd2.Parameters.AddWithValue("@id", idd);
            string vista = cmd2.ExecuteScalar().ToString();*/

            //Consola con = ControladorConsola.GetOne(idd);

            /*
            conexion.Conectar();
            string sql = "use tienda; select * from Consola where IdConsola=@id";
            SqlCommand cmd = new SqlCommand(sql, conexion.Conectar());
            cmd.Parameters.AddWithValue("@id",idd);
            SqlDataReader reader = cmd.ExecuteReader();
            //string nombre="";
            //string vista="";
            if (reader.HasRows)
            {
              txtID.Text = Convert.ToString(reader["IdConsola"]);
              txtNombre.Text = Convert.ToString(reader["Nombre"]);
              boxEstado.Text = Convert.ToString(reader["Visible"]);
            }*/

            /*
            txtID.Text = idd.ToString();
            txtNombre.Text = nombre;
            boxEstado.Text = vista;*/


        }



        private void limpiarErrores()
        {
            errNombre.Text = "";
            errNombre.Hide();
        }

        private void GuardarConsola()
        {
            Consola con = new Consola()
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Vista = bool.Parse(boxEstado.Text)

            };

            ListaConsola lista = ControladorConsola.ListaConsola;
            lista.GuardarEnInstancia(con);
            lista.GuardarEnMemoria(con);

        }

        private bool ValidarConsola(out bool errorMsg)
        {

            errorMsg = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMsg = false;
                string error = "Debe ingresar el nombre";
                errNombre.Text = error;
                errNombre.Show();

            }
            return errorMsg;
        }


        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            bool consolaValidada = ValidarConsola(out bool errorMsg);

            if (consolaValidada)
            {
                consolaNueva = new Consola()
                {
                    Id = int.Parse(txtID.Text),
                    Nombre = txtNombre.Text,
                    Vista = bool.Parse(boxEstado.Text)
                    
                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    this.DialogResult = DialogResult.Cancel;
            }

        }

        private void llenarBoxEstado()
        {
            boxEstado.Items.Add("True");
            boxEstado.Items.Add("False");

        }
    }
}
