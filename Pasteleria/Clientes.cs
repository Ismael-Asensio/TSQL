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
    public partial class Clientes : Form
    {
        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public Clientes()
        {
            InitializeComponent();
            pictureBox2.BorderStyle = BorderStyle.None;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;

            //txtPN.Enabled = true;
            //txtSN.Enabled = true;
            //txtPRA.Enabled = true;
            //txtSA.Enabled = true;

            //dgvClientes.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.CurrentCell = null;

            if (txtBuscarxID.Text != "")
            {


                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {



                        if (c.Value != null && c.Value.ToString().ToUpper().IndexOf(txtBuscarxID.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }


                    }
                }




            }
            else
            {

                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = true;
                }


            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BackColor = Color.Transparent;

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos y realizar la inserción
                if (ValidarCampos())
                {
                    // Llamar al procedimiento almacenado para insertar un nuevo empleado
                    InsertarCliente();


                    CargarClientes();

                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            txtPN.Text = "";
            txtSN.Text = "";
            txtSA.Text = "";
            txtPRA.Text = "";
            txtDirC.Text = "";
            txtTelf.Text = "";
            label4.Text = "";
            comboBoxEstado.SelectedIndex = -1;

        }
        private void InsertarCliente()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("InsertarCliente", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar los parámetros según los valores de los controles en el formulario
                comando.Parameters.AddWithValue("@PNombreC", txtPN.Text);
                comando.Parameters.AddWithValue("@SNombreC", txtSN.Text);
                comando.Parameters.AddWithValue("@PApellidoC", txtPRA.Text);
                comando.Parameters.AddWithValue("@SApellidoC", txtSA.Text);
                comando.Parameters.AddWithValue("@DirC", txtDirC.Text);
                comando.Parameters.AddWithValue("@TelC", txtTelf.Text);
                comando.Parameters.AddWithValue("@Estado", float.Parse(comboBoxEstado.Text)); // Considera si realmente necesitas un float aquí
                comando.ExecuteNonQuery();
            }
        }

        private void CargarClientes()
        {
            // Carga los empleados en el DataGridView
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Clientes";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tablaEmpleados = new DataTable();
                adaptador.Fill(tablaEmpleados);
                dgvClientes.DataSource = tablaEmpleados;


            }

            txtPN.Enabled = true;
            txtSN.Enabled = true;
            txtPRA.Enabled = true;
            txtSA.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
            txtDirC.Text = "";
            txtTelf.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            label4.Text = "";



            CargarClientes();
        }


        private void ActualizarCliente()
        {
            try
            {
                // Verificar que IdEmpleado sea válido
                if (!int.TryParse(label4.Text, out int IdCliente))
                {
                    MessageBox.Show("Seleccione un empleado válido desde el DataGridView.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que los campos no estén vacíos
                if (CamposValidos2())
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    using (SqlCommand comando = new SqlCommand("ActualizarCliente", conexion))
                    {
                        conexion.Open();
                        comando.CommandType = CommandType.StoredProcedure;

                        // Asignar los parámetros según los valores de los controles en el formulario
                        comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                        comando.Parameters.AddWithValue("@NuevaDirC", txtDirC.Text);
                        comando.Parameters.AddWithValue("@NuevoTelC", txtTelf.Text);
                        comando.Parameters.AddWithValue("@NuevoEstado", float.Parse(comboBoxEstado.Text));

                        // Ejecutar el procedimiento almacenado
                        comando.ExecuteNonQuery();
                    }

                    // Actualizar el DataGridView con los nuevos datos
                    CargarClientes();

                    MessageBox.Show("Cliente actualizado correctamente.");


                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar la selección de la fila en el DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {




                DataGridViewRow filaSeleccionada = dgvClientes.SelectedRows[0];

                if (int.TryParse(filaSeleccionada.Cells["IdCliente"].Value.ToString(), out int idEmpleado))
                {
                    // Puedes almacenar el IdProducto en una variable global o en un TextBox, según tus necesidades
                    label4.Text = idEmpleado.ToString();
                }
                txtDirC.Enabled = true;
                txtTelf.Enabled = true;

                comboBoxEstado.Enabled = true;

                // Obtener el valor de la columna "CantidadProduc" (ajusta el índice según tu DataGridView)
                string DirC = filaSeleccionada.Cells["DirC"].Value.ToString();

                // Obtener el valor de la columna "Precio" (ajusta el índice según tu DataGridView)
                string TelC = filaSeleccionada.Cells["TelC"].Value.ToString();


                string estado = filaSeleccionada.Cells["Estado"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                txtDirC.Text = DirC;
                txtTelf.Text = TelC;
                comboBoxEstado.Text = estado;
            }

            txtPN.Enabled = false;
            txtSN.Enabled = false;
            txtPRA.Enabled = false;
            txtSA.Enabled = false;
        }

        private bool CamposValidos2()
        {
            // Verificar que los campos no estén vacíos
            return !string.IsNullOrWhiteSpace(txtTelf.Text) &&
                   !string.IsNullOrWhiteSpace(txtDirC.Text) &&

                   comboBoxEstado.SelectedItem != null;
        }

        private bool ValidarCampos()
        {
            // Realiza la validación de los campos según tus necesidades
            // Puedes agregar más validaciones según los tipos de datos esperados
            return !string.IsNullOrWhiteSpace(txtPN.Text) &&
                !string.IsNullOrWhiteSpace(txtSN.Text) &&
                !string.IsNullOrWhiteSpace(txtPRA.Text) &&
                !string.IsNullOrWhiteSpace(txtSA.Text) &&
                   !string.IsNullOrWhiteSpace(txtDirC.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelf.Text) &&

                   comboBoxEstado.SelectedItem != null;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado una fila en el DataGridView
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    // Obtener el IdProducto de la fila seleccionada (ajusta el índice según tu DataGridView)
                    int idcliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IdCliente"].Value);

                    // Verificar si el producto ya está inactivo
                    if (EmpleadoEstaInactivo(idcliente))
                    {
                        MessageBox.Show("El Cliente ya está inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Llamar al procedimiento almacenado para inactivar el producto
                        DarDeBajaEmpleado(idcliente);

                        // Actualizar el DataGridView con los nuevos datos
                        CargarClientes();

                        MessageBox.Show("Cliente marcado como inactivo correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente desde el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inactivar el Cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            txtDirC.Text = "";
            txtTelf.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            label4.Text = "";



            CargarClientes();
        }

        private bool EmpleadoEstaInactivo(int idCliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT Estado FROM Clientes WHERE IdCliente = @IdCliente", conexion))
            {
                conexion.Open();
                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                // Obtener el estado del producto
                object resultado = comando.ExecuteScalar();

                // Verificar si el resultado no es nulo y es igual a 0 (inactivo)
                return resultado != null && Convert.ToInt32(resultado) == 0;
            }
        }

        private void DarDeBajaEmpleado(int IdCliente)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("DarDeBajaCliente", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar el parámetro @IdProducto al procedimiento almacenado
                comando.Parameters.AddWithValue("@IdCliente", IdCliente);

                // Ejecutar el procedimiento almacenado
                comando.ExecuteNonQuery();
            }
        }

        private void txtBuscarxID_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.CurrentCell = null;

            if (txtBuscarxID.Text != "")
            {


                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {



                        if (c.Value != null && c.Value.ToString().ToUpper().IndexOf(txtBuscarxID.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }


                    }
                }




            }
            else
            {

                foreach (DataGridViewRow r in dgvClientes.Rows)
                {
                    r.Visible = true;
                }


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
