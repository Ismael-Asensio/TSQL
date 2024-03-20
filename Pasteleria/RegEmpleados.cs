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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pasteleria
{
    public partial class RegEmpleados : Form
    {

        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public RegEmpleados()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos y realizar la inserción
                if (ValidarCampos())
                {
                    // Llamar al procedimiento almacenado para insertar un nuevo empleado
                    InsertarEmpleado();

                    // Actualizar el DataGridView con los nuevos datos
                    CargarEmpleados();

                    MessageBox.Show("Empleado insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtxApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtDireccion.Text = "";
            txtSucursal.Text = "";
            txtTelefono.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            label10.Text = "";

        }


        private bool ValidarCampos()
        {
            // Realiza la validación de los campos según tus necesidades
            // Puedes agregar más validaciones según los tipos de datos esperados
            return !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtSegundoNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtxApellidoMaterno.Text) &&
                !string.IsNullOrWhiteSpace(txtxApellidoMaterno.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   int.TryParse(txtSucursal.Text, out int idSucursal) &&
                   comboBoxEstado.SelectedItem != null;
        }

        private void InsertarEmpleado()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("InsertarEmpleado", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar los parámetros según los valores de los controles en el formulario
                comando.Parameters.AddWithValue("@NombreE", txtNombre.Text);
                comando.Parameters.AddWithValue("@SNombreE", txtSegundoNombre.Text);
                comando.Parameters.AddWithValue("@PApellidoE", txtApellidoPaterno.Text);
                comando.Parameters.AddWithValue("@SApellidoE", txtxApellidoMaterno.Text);
                comando.Parameters.AddWithValue("@DirE", txtDireccion.Text);
                comando.Parameters.AddWithValue("@TelE", txtTelefono.Text);
                comando.Parameters.AddWithValue("@IdSucursal", int.Parse(txtSucursal.Text));
                comando.Parameters.AddWithValue("@Estado", float.Parse(comboBoxEstado.Text)); // Considera si realmente necesitas un float aquí
                comando.ExecuteNonQuery();
            }
        }

        private void CargarEmpleados()
        {
            // Carga los empleados en el DataGridView
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Empleados";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tablaEmpleados = new DataTable();
                adaptador.Fill(tablaEmpleados);
                dgvEmpleados.DataSource = tablaEmpleados;


            }

            txtNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
            txtxApellidoMaterno.Enabled = true;
            txtApellidoPaterno.Enabled = true;
           
        }
        private void RegEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            dgvEmpleados.ReadOnly = true;

            dgvEmpleados.AllowUserToAddRows = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
            txtDireccion.Text = "";
            txtSucursal.Text = "";
            txtTelefono.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            label10.Text = "";



            CargarEmpleados();

        }


        private void ActualizarEmpleado()
        {
            try
            {
                // Verificar que IdEmpleado sea válido
                if (!int.TryParse(label10.Text, out int idEmpleado))
                {
                    MessageBox.Show("Seleccione un empleado válido desde el DataGridView.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que los campos no estén vacíos
                if (CamposValidos2())
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    using (SqlCommand comando = new SqlCommand("ActualizarEmpleado", conexion))
                    {
                        conexion.Open();
                        comando.CommandType = CommandType.StoredProcedure;

                        // Asignar los parámetros según los valores de los controles en el formulario
                        comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        comando.Parameters.AddWithValue("@NuevaDirE", txtDireccion.Text);
                        comando.Parameters.AddWithValue("@NuevoTelE", txtTelefono.Text);
                        comando.Parameters.AddWithValue("@NuevoIdSucursal", int.Parse(txtSucursal.Text));
                        comando.Parameters.AddWithValue("@NuevoEstado", float.Parse(comboBoxEstado.Text));

                        // Ejecutar el procedimiento almacenado
                        comando.ExecuteNonQuery();
                    }

                    // Actualizar el DataGridView con los nuevos datos
                    CargarEmpleados();

                    MessageBox.Show("Empleado actualizado correctamente.");
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

        private bool CamposValidos2()
        {
            // Verificar que los campos no estén vacíos
            return !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                   !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                   !string.IsNullOrWhiteSpace(txtSucursal.Text) &&
                   comboBoxEstado.SelectedItem != null;
        }


        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar la selección de la fila en el DataGridView
            if (dgvEmpleados.SelectedRows.Count > 0)
            {




                DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
                // Obtener el valor de la columna IdProducto (ajusta el índice según tu DataGridView)
                if (int.TryParse(filaSeleccionada.Cells["IdEmpleado"].Value.ToString(), out int idEmpleado))
                {
                    // Puedes almacenar el IdProducto en una variable global o en un TextBox, según tus necesidades
                    label10.Text = idEmpleado.ToString();
                }
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtSucursal.Enabled = true;
                comboBoxEstado.Enabled = true;

                // Obtener el valor de la columna "CantidadProduc" (ajusta el índice según tu DataGridView)
                string DirE = filaSeleccionada.Cells["DirE"].Value.ToString();

                // Obtener el valor de la columna "Precio" (ajusta el índice según tu DataGridView)
                string TelE = filaSeleccionada.Cells["TelE"].Value.ToString();
                string IdSucursal = filaSeleccionada.Cells["IdSucursal"].Value.ToString();

                string estado = filaSeleccionada.Cells["Estado"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                txtDireccion.Text = DirE;
                txtSucursal.Text = IdSucursal;
                txtTelefono.Text = TelE;
                comboBoxEstado.Text = estado;
            }

            txtNombre.Enabled = false;
            txtSegundoNombre.Enabled = false;
            txtxApellidoMaterno.Enabled = false;
            txtApellidoPaterno.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado una fila en el DataGridView
                if (dgvEmpleados.SelectedRows.Count > 0)
                {
                    // Obtener el IdProducto de la fila seleccionada (ajusta el índice según tu DataGridView)
                    int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value);

                    // Verificar si el producto ya está inactivo
                    if (EmpleadoEstaInactivo(idEmpleado))
                    {
                        MessageBox.Show("El Empleado ya está inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Llamar al procedimiento almacenado para inactivar el producto
                        DarDeBajaEmpleado(idEmpleado);

                        // Actualizar el DataGridView con los nuevos datos
                        CargarEmpleados();

                        MessageBox.Show("Producto marcado como inactivo correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto desde el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inactivar el Empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtSucursal.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            label10.Text = "";



            CargarEmpleados();
        }
        private bool EmpleadoEstaInactivo(int idEmpleado)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT Estado FROM Empleados WHERE IdEmpleado = @IdEmpleado", conexion))
            {
                conexion.Open();
                comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                // Obtener el estado del producto
                object resultado = comando.ExecuteScalar();

                // Verificar si el resultado no es nulo y es igual a 0 (inactivo)
                return resultado != null && Convert.ToInt32(resultado) == 0;
            }
        }

        private void DarDeBajaEmpleado(int idProducto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("DarDeBajaEmpleado", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar el parámetro @IdProducto al procedimiento almacenado
                comando.Parameters.AddWithValue("@IdEmpleado", idProducto);

                // Ejecutar el procedimiento almacenado
                comando.ExecuteNonQuery();
            }
        }

        private void txtBuscarxID_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.CurrentCell = null;

            if (txtBuscarxID.Text != "")
            {


                foreach (DataGridViewRow r in dgvEmpleados.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvEmpleados.Rows)
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

                foreach (DataGridViewRow r in dgvEmpleados.Rows)
                {
                    r.Visible = true;
                }


            }

            txtApellidoPaterno.Enabled = true;
            txtxApellidoMaterno.Enabled = true;
            txtNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
        }
    }
}

