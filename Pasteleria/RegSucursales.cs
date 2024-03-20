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

namespace Pasteleria
{
    public partial class RegSucursales : Form
    {
        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public RegSucursales()
        {
            InitializeComponent();
        }


        private void CargarSucursales()
        {
            // Carga los empleados en el DataGridView
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Sucursales";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tablaSucursales = new DataTable();
                adaptador.Fill(tablaSucursales);
                dataGridView1.DataSource = tablaSucursales;
            }
        }

        private void RegSucursales_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }
    }
}
