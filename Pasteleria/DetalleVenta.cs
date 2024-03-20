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
    public partial class DetalleVenta : Form
    {
        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {

            String consulta = "select * from RegistroVentas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvDetalleVenta.DataSource = dt;

            dgvDetalleVenta.ReadOnly = true;
        }
    }
}
