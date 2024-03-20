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
    public partial class ProductosAdmin : Form
    {
        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public ProductosAdmin()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ProductosAdmin_Load(object sender, EventArgs e)
        {
            String consulta = " select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProductosAdmin.DataSource = dt;

            dgvProductosAdmin.ReadOnly = true;


            dgvProductosAdmin.AllowUserToAddRows = false;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los campos no estén vacíos
                if (CamposValidos())
                {
                    // Insertar el producto en la base de datos
                    InsertarProducto();

                    // Actualizar el DataGridView con los nuevos datos
                    CargarProductos();

                    MessageBox.Show("Producto insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el producto: {ex.Message}");
            }

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            comboBox1.SelectedIndex = -1;

            // Limpiar un TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void InsertarProducto()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                using (SqlCommand comando = new SqlCommand("InsertarProducto", conexion))
                {
                    conexion.Open();
                    comando.CommandType = CommandType.StoredProcedure;

                    // Asigna los parámetros según los valores de los controles en el formulario
                    comando.Parameters.AddWithValue("@Fech_Elab", dateTimePicker1.Value);
                    comando.Parameters.AddWithValue("@Fech_Venc", dateTimePicker2.Value);
                    comando.Parameters.AddWithValue("@NombreProduc", textBox1.Text);
                    comando.Parameters.AddWithValue("@DescripProduc", textBox2.Text);
                    comando.Parameters.AddWithValue("@PrecUnit", float.Parse(textBox3.Text));
                    comando.Parameters.AddWithValue("@CantidadProduc", int.Parse(textBox4.Text));

                    // Ejecuta el procedimiento almacenado
                    comando.ExecuteNonQuery();
                }

                // Actualizar el DataGridView con los nuevos datos
                CargarProductos();

                MessageBox.Show("Producto insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el producto: {ex.Message}");
            }
        }

        private void CargarProductos()
        {
            // Carga los productos en el DataGridView
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM productos";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tablaProductos = new DataTable();
                adaptador.Fill(tablaProductos);
                dgvProductosAdmin.DataSource = tablaProductos;
            }
        }

        private bool CamposValidos()
        {
            // Verifica que los campos no estén vacíos
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text) &&
                   comboBox1.SelectedItem != null;
        }
        private bool CamposValidos2()
        {
            // Verifica que los campos no estén vacíos
            return
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text);
        }

        private void dgvProductosAdmin_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar la selección de la fila en el DataGridView
            if (dgvProductosAdmin.SelectedRows.Count > 0)
            {




                DataGridViewRow filaSeleccionada = dgvProductosAdmin.SelectedRows[0];
                // Obtener el valor de la columna IdProducto (ajusta el índice según tu DataGridView)
                if (int.TryParse(filaSeleccionada.Cells["IdProducto"].Value.ToString(), out int idProducto))
                {
                    // Puedes almacenar el IdProducto en una variable global o en un TextBox, según tus necesidades
                    label12.Text = idProducto.ToString();
                }
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                comboBox1.Enabled = true;

                // Obtener el valor de la columna "CantidadProduc" (ajusta el índice según tu DataGridView)
                string cantidad = filaSeleccionada.Cells["CantidadProduc"].Value.ToString();

                // Obtener el valor de la columna "Precio" (ajusta el índice según tu DataGridView)
                string precio = filaSeleccionada.Cells["PrecUnit"].Value.ToString();

                string estado = filaSeleccionada.Cells["Estado"].Value.ToString();

                // Mostrar los valores en los TextBox correspondientes
                textBox4.Text = cantidad;
                textBox3.Text = precio;
                comboBox1.Text = estado;
            }

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
            label12.Text = "";


            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;

        }

        private void ActualizarProducto()
        {
            try
            {
                // Verificar que IdProducto sea válido
                if (!int.TryParse(label12.Text, out int idProducto))
                {
                    MessageBox.Show("Seleccione un producto válido desde el DataGridView.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que los campos no estén vacíos
                if (CamposValidos2())
                {

                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    using (SqlCommand comando = new SqlCommand("ActualizarCantidadPrecioEstado", conexion))
                    {
                        conexion.Open();
                        comando.CommandType = CommandType.StoredProcedure;

                        // Asigna los parámetros según los valores de los controles en el formulario
                        comando.Parameters.AddWithValue("@IdProducto", idProducto);
                        comando.Parameters.AddWithValue("@NuevaCantidad", int.Parse(textBox4.Text));
                        comando.Parameters.AddWithValue("@NuevoPrecio", float.Parse(textBox3.Text));
                        comando.Parameters.AddWithValue("@Nuevoestado", float.Parse(comboBox1.Text));

                        // Ejecuta el procedimiento almacenado
                        comando.ExecuteNonQuery();
                    }

                    // Actualizar el DataGridView con los nuevos datos
                    CargarProductos();

                    MessageBox.Show("Producto actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado una fila en el DataGridView
                if (dgvProductosAdmin.SelectedRows.Count > 0)
                {
                    // Obtener el IdProducto de la fila seleccionada (ajusta el índice según tu DataGridView)
                    int idProducto = Convert.ToInt32(dgvProductosAdmin.SelectedRows[0].Cells["IdProducto"].Value);

                    // Verificar si el producto ya está inactivo
                    if (ProductoEstaInactivo(idProducto))
                    {
                        MessageBox.Show("El producto ya está inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Llamar al procedimiento almacenado para inactivar el producto
                        InactivarProducto(idProducto);

                        // Actualizar el DataGridView con los nuevos datos
                        CargarProductos();

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
                MessageBox.Show($"Error al inactivar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
            label12.Text = "";

            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;

            Ventas_Load();

        }
        private void Ventas_Load()
        {
            String consulta = " select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProductosAdmin.DataSource = dt;
        }
        private bool ProductoEstaInactivo(int idProducto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT Estado FROM productos WHERE IdProducto = @IdProducto", conexion))
            {
                conexion.Open();
                comando.Parameters.AddWithValue("@IdProducto", idProducto);

                // Obtener el estado del producto
                object resultado = comando.ExecuteScalar();

                // Verificar si el resultado no es nulo y es igual a 0 (inactivo)
                return resultado != null && Convert.ToInt32(resultado) == 0;
            }
        }

        private void InactivarProducto(int idProducto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("InactivarProducto", conexion))
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;

                // Asignar el parámetro @IdProducto al procedimiento almacenado
                comando.Parameters.AddWithValue("@IdProducto", idProducto);

                // Ejecutar el procedimiento almacenado
                comando.ExecuteNonQuery();
            }
        }
    }
}
