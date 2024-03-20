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
    public partial class Catalogo : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataTable tablaDatos;
        public Catalogo()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD;Integrated Security=True";

            // Crear la conexión
            conexion = new SqlConnection(cadenaConexion);

            // Crear un adaptador de datos
            adaptador = new SqlDataAdapter("SELECT * FROM productos", conexion);

            // Crear un DataTable para almacenar los datos
            tablaDatos = new DataTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCatalogo.CurrentCell = null;

            if (txtCat.Text != "")
            {


                foreach (DataGridViewRow r in dgvCatalogo.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvCatalogo.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {



                        if (c.Value != null && c.Value.ToString().ToUpper().IndexOf(txtCat.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }


                    }
                }




            }
            else
            {

                foreach (DataGridViewRow r in dgvCatalogo.Rows)
                {
                    r.Visible = true;
                }


            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // Abrir la conexión
            conexion.Open();

            // Llenar el DataTable con los datos de la base de datos
            adaptador.Fill(tablaDatos);

            // Asignar el DataTable como fuente de datos para el DataGridView
            dgvCatalogo.DataSource = tablaDatos;

            // Cerrar la conexión
            conexion.Close();

            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
            this.Hide();
        }
    }
}
