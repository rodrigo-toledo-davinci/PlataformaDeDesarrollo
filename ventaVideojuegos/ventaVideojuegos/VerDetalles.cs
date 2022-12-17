using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class VerDetalles : Form
    {
       
        public VerDetalles(int idVenta)
        {
            InitializeComponent();
            lblVenta.Text = lblVenta.Text + " " + idVenta;
            verProductosVendidos(idVenta);
            visualizarDetallesDB(idVenta);
        }

        public void verProductosVendidos(int idVenta)
        {
          

            foreach(Venta vta in ControladorVentas.Ventas)
            {
                if(idVenta == vta.Id)
                {

                    int rowIndex = dataGridViewV.Rows.Add();
                    dataGridViewV.Rows[rowIndex].Cells[0].Value = vta.nombreProducto.ToString();
                    dataGridViewV.Rows[rowIndex].Cells[1].Value = vta.precioProducto.ToString();
                    dataGridViewV.Rows[rowIndex].Cells[2].Value = vta.cantidadProducto.ToString();
                    dataGridViewV.Rows[rowIndex].Cells[3].Value = vta.valorTotal.ToString();
                }
            }
        }

        private void visualizarDetallesDB(int idventa)
        {
            dataGridViewDetalles1.DataSource = llenar_grid_detalles(idventa);
        }

        //Aca se genera la consulta SQL que llena los registros de la tabla de detalles
        public DataTable llenar_grid_detalles(int idventa)
        {
            conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Use tienda; select * from Venta where IdVenta=@id;";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());
            cmd.Parameters.AddWithValue("@id", idventa);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            return dt;
        }

        private void btnCerrarDetails_Click(object sender, EventArgs e)
        {
            
            dataGridViewV.Rows.Clear();
            this.Close();

        }
    }
}
