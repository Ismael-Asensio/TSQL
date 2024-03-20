using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Conexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pasteleria
{


    public partial class Ventas : Form
    {
        string cadenaConexion = "Data Source=JOSUEB;Initial Catalog=PasteleriaBD ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlConnection conexion2;

        private SqlCommand comando;
        private SqlCommand comando2;

        private SqlDataReader lector;
        private SqlDataReader lector2;
        public Ventas()
        {
            InitializeComponent();

            conexion = new SqlConnection(cadenaConexion);
            conexion2 = new SqlConnection(cadenaConexion);




        }



        private void Ventas_Load(object sender, EventArgs e)
        {

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            String consulta = "SELECT * FROM productos WHERE Estado = 1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProductos.DataSource = dt;

            dgvProductos.ReadOnly = true;
            dgvCarrito.ReadOnly = true;

            dgvProductos.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToAddRows = false;

            CargarProductosEnComboBox();
            CargarNombresEnComboBox();

        }




        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.BackColor = Color.Transparent;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.None;
            panel5.BackColor = Color.Transparent;
        }

        private void txtComprar_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.CurrentCell = null;

            if (txtComprar.Text != "")
            {


                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {



                        if (c.Value != null && c.Value.ToString().ToUpper().IndexOf(txtComprar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }


                    }
                }




            }
            else
            {

                foreach (DataGridViewRow r in dgvProductos.Rows)
                {
                    r.Visible = true;
                }


            }
        }

        private void strech(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar la tabla y el ComboBox
            Ventas_Load();
        }

        private void Ventas_Load()
        {
            String consulta = "SELECT * FROM productos WHERE Estado = 1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaConexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvProductos.DataSource = dt;

            dgvProductos.ReadOnly = true;
            dgvCarrito.ReadOnly = true;

            dgvProductos.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToAddRows = false;

            CargarProductosEnComboBox();
            CargarNombresEnComboBox();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void CargarProductosEnComboBox()
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Consulta SQL para obtener los nombres de los 
                string consulta = "SELECT NombreProduc FROM productos WHERE Estado = 1";
                comando = new SqlCommand(consulta, conexion);

                // Ejecutar la consulta y obtener un lector de datos
                lector = comando.ExecuteReader();

                // Limpiar el ComboBox antes de cargar los datos
                comboBoxProductos.Items.Clear();

                // Iterar a través de los resultados y agregarlos al ComboBox
                while (lector.Read())
                {
                    string nombreProducto = lector["NombreProduc"].ToString();
                    comboBoxProductos.Items.Add(nombreProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar el lector y la conexión
                lector.Close();
                conexion.Close();
            }
        }


        private void CargarNombresEnComboBox()
        {
            try
            {
                // Abrir la conexión
                conexion2.Open();

                // Consulta SQL para obtener los nombres de los productos
                string consulta = "SELECT PNombreC FROM Clientes";
                comando2 = new SqlCommand(consulta, conexion2);

                // Ejecutar la consulta y obtener un lector de datos
                lector2 = comando2.ExecuteReader();

                // Limpiar el ComboBox antes de cargar los datos
                comboBox1.Items.Clear();

                // Iterar a través de los resultados y agregarlos al ComboBox
                while (lector2.Read())
                {
                    string nombrec = lector2["PNombreC"].ToString();
                    comboBox1.Items.Add(nombrec);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Nombre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar el lector y la conexión
                lector2.Close();
                conexion2.Close();
            }
        }

        private void MostrarIDC()
        {
            try
            {
                // Abrir la conexión
                conexion2.Open();

                // Consulta SQL para obtener el precio unitario del producto seleccionado
                string consulta2 = "SELECT IdCliente FROM Clientes WHERE PNombreC = @PNombreC";
                comando2 = new SqlCommand(consulta2, conexion2);
                comando2.Parameters.AddWithValue("@PNombreC", comboBox1.SelectedItem.ToString());

                // Obtener el precio unitario
                object IDC = comando2.ExecuteScalar();


                txtIDC.Text = IDC != null ? IDC.ToString() : "";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                // Cerrar la conexión
                conexion2.Close();
            }
        }

        private void MostrarPrecioUnitario()
        {
            try
            {
                if (comboBoxProductos.SelectedItem != null) // Verificar si hay un producto seleccionado
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Consulta SQL para obtener el precio unitario del producto seleccionado
                    string consulta = "SELECT PrecUnit FROM Productos WHERE NombreProduc = @NombreProduc";
                    comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@NombreProduc", comboBoxProductos.SelectedItem.ToString());

                    // Obtener el precio unitario
                    object precioUnitario = comando.ExecuteScalar();

                    // Mostrar el precio unitario en un TextBox o donde desees
                    txtPrecUnit.Text = precioUnitario != null ? precioUnitario.ToString() : "";
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al obtener el precio unitario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión en el bloque finally
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarPrecioUnitario();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }



        private decimal ObtenerTotalCompraDesdeBD(int cantidad, string precioUnitario)
        {
            decimal total = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.CalcularTotalCompra(@Cantidad, @PrecioUnitario)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el total desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return total;
        }
        private void CalcularTotalFila(int rowIndex)
        {
            // Obtener la cantidad y el precio unitario desde las celdas correspondientes
            int cantidad = Convert.ToInt32(dgvCarrito.Rows[rowIndex].Cells["Cantidad"].Value);

            // Agrega mensajes de depuración
            Console.WriteLine("Cantidad: " + cantidad);

            // Validar el valor en txtPrecUnit.Text
            decimal precioUnitario;
            if (decimal.TryParse(txtPrecUnit.Text, out precioUnitario))
            {
                // Agrega mensajes de depuración
                Console.WriteLine("Precio Unitario: " + precioUnitario);

                // Calcular el total y mostrarlo en la celda correspondiente
                decimal total = cantidad * precioUnitario;
                dgvCarrito.Rows[rowIndex].Cells["Total"].Value = total;

                // Agrega mensajes de depuración
                Console.WriteLine("Total: " + total);
            }
            else
            {
                MessageBox.Show("El precio unitario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ClienteExisteEnBD(string idCliente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Clientes WHERE IdCliente = @IdCliente";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {



            // Obtener la cantidad del control TextBox
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                // Verificar si el ID del cliente existe
                if (!string.IsNullOrEmpty(txtIDC.Text) && ClienteExisteEnBD(txtIDC.Text))
                {

                    // Obtener la cantidad disponible del producto seleccionado desde la base de datos
                    int cantidadDisponible = ObtenerCantidadDisponibleDesdeBD(comboBoxProductos.SelectedItem.ToString());

                    // Verificar si la cantidad a comprar es mayor que la cantidad disponible
                    if (cantidad <= cantidadDisponible)
                    {
                        // Resto del código para agregar al carrito aquí
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente cantidad disponible en inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    // Buscar si ya existe una fila con el mismo producto
                    DataGridViewRow filaExistente = null;
                    foreach (DataGridViewRow fila in dgvCarrito.Rows)
                    {
                        if (fila.Cells["NombreProducto"].Value != null && fila.Cells["NombreProducto"].Value.ToString() == comboBoxProductos.SelectedItem.ToString())
                        {
                            filaExistente = fila;
                            break;
                        }
                    }

                    if (filaExistente != null)
                    {
                        // Actualizar la cantidad en la fila existente
                        int cantidadExistente = (int)filaExistente.Cells["Cantidad"].Value;
                        filaExistente.Cells["Cantidad"].Value = cantidadExistente + cantidad;

                        // Calcular el total para la fila existente
                        int rowIndex = filaExistente.Index;
                        CalcularTotalFila(rowIndex);
                    }
                    else
                    {
                        // Agregar la primera fila directamente a las celdas
                        if (dgvCarrito.Rows.Count == 0)
                        {
                            dgvCarrito.Rows.Add(comboBoxProductos.SelectedItem, cantidad, txtPrecUnit.Text, ObtenerTotalCompraDesdeBD(cantidad, txtPrecUnit.Text), txtIDC.Text);
                        }
                        else
                        {
                            // Para las filas siguientes, utiliza Rows.Add como antes
                            dgvCarrito.Rows.Add(comboBoxProductos.SelectedItem, cantidad, txtPrecUnit.Text, ObtenerTotalCompraDesdeBD(cantidad, txtPrecUnit.Text), txtIDC.Text);

                            // Calcular el total para la fila recién agregada
                            int rowIndex = dgvCarrito.Rows.Count - 1;
                            CalcularTotalFila(rowIndex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El ID del cliente no existe. Por favor, ingrese un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            comboBoxProductos.SelectedIndex = -1;

            // Limpiar un TextBox
            txtCantidad.Text = "";
            txtPrecUnit.Text = "";
            txtIDC.Text = "";
            txtPrecUnit.Text = "";






        }



        private void RealizarCompra()
        {
            // Obtener el nombre del producto seleccionado en el DataGridView
            string nombreProducto = dgvCarrito.CurrentRow.Cells["NombreProducto"].Value.ToString();

            // Obtener la cantidad disponible en la tabla de productos
            int cantidadDisponible = ObtenerCantidadDisponibleDesdeBD(nombreProducto);

            // Obtener la cantidad en el DataGridView
            int cantidadEnCarrito = Convert.ToInt32(dgvCarrito.CurrentRow.Cells["Cantidad"].Value);

            // Comparar las cantidades
            if (cantidadEnCarrito > cantidadDisponible)
            {
                MessageBox.Show($"No se puede realizar la compra. La cantidad en el carrito ({cantidadEnCarrito}) es mayor que la cantidad disponible en la tabla de productos ({cantidadDisponible}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Verificar si hay al menos una fila en el DataGridView
                if (dgvCarrito.Rows.Count > 0)
                {
                    // Eliminar la última fila
                    dgvCarrito.Rows.RemoveAt(dgvCarrito.Rows.Count - 1);
                }
            }
            else
            {
                // Realizar la compra (agregar la lógica de compra aquí)
                // ...

                // Actualizar la cantidad en la tabla de productos (restar la cantidad comprada)
                ActualizarCantidadEnBD(nombreProducto, cantidadEnCarrito);
            }
        }

        private int ObtenerCantidadDesdeBD(string nombreProducto)
        {
            // Aquí deberías implementar la lógica para obtener la cantidad disponible desde la base de datos
            // Puedes usar una consulta SQL para obtener la cantidad disponible para el producto específico

            int cantidadDisponible = 0; // Inicializar con un valor predeterminado

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT CantidadProduc FROM productos WHERE NombreProduc = @NombreProduc";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NombreProduc", nombreProducto);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            cantidadDisponible = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al consultar la base de datos
                Console.WriteLine("Error al obtener la cantidad desde la base de datos: " + ex.Message);
            }

            return cantidadDisponible;
        }

        private int ObtenerCantidadDisponibleDesdeBD(string nombreProducto)
        {
            // Aquí deberías implementar la lógica para obtener la cantidad disponible desde la base de datos
            // Puedes usar una consulta SQL para obtener la cantidad disponible para el producto específico

            // Ejemplo: SELECT CantidadProduc FROM productos WHERE NombreProduc = @NombreProducto

            // Supongamos que tienes un método para ejecutar la consulta y obtener el resultado
            int cantidadDisponible = ObtenerCantidadDesdeBD(nombreProducto);

            return cantidadDisponible;
        }

        private void ActualizarCantidadEnBD(string nombreProducto, int cantidadComprada)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("ActualizarCantidadProducto", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                        cmd.Parameters.AddWithValue("@CantidadComprada", cantidadComprada);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Aquí puedes agregar código adicional después de actualizar la cantidad en la base de datos
                // Por ejemplo, mostrar un mensaje de éxito, actualizar la tabla, etc.
                MessageBox.Show($"Compra realizada. Se han restado {cantidadComprada} unidades de {nombreProducto}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cantidad en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Ventas_Load();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas en el dgvCarrito
            if (dgvCarrito.Rows.Count > 0)
            {
                // Obtener la última fila agregada al dgvCarrito
                DataGridViewRow ultimaFila = dgvCarrito.Rows[dgvCarrito.Rows.Count - 1];

                // Obtener el nombre del producto seleccionado en el DataGridView
                string nombreProducto = ultimaFila.Cells["NombreProducto"].Value.ToString();

                // Obtener la cantidad disponible en la tabla de productos
                int cantidadDisponible = ObtenerCantidadDisponibleDesdeBD(nombreProducto);

                // Obtener la cantidad en el DataGridView
                int cantidadEnCarrito = Convert.ToInt32(ultimaFila.Cells["Cantidad"].Value);

                // Comparar las cantidades y realizar la compra automáticamente
                if (cantidadEnCarrito <= cantidadDisponible  || cantidadEnCarrito>0)
                {

                    ActualizarCantidadEnBD(nombreProducto, cantidadEnCarrito);

                    

                    // Actualizar la interfaz de usuario
                    Ventas_Load();
                }
                else
                {
                    MessageBox.Show($"No se puede realizar la compra. La cantidad en el carrito ({cantidadEnCarrito}) es mayor que la cantidad disponible en la tabla de productos ({cantidadDisponible}). O es igual a 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar una compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                using (SqlConnection conexion3 = new SqlConnection(cadenaConexion))
                {
                    conexion3.Open();

                    // Recorrer las filas del DataGridView y realizar la inserción
                    foreach (DataGridViewRow fila in dgvCarrito.Rows)
                    {
                        string nombreProducto = fila.Cells["NombreProducto"].Value.ToString();
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        float precioUnitario = Convert.ToSingle(fila.Cells["PrecioUnitario"].Value);
                        float total = Convert.ToSingle(fila.Cells["Total"].Value);
                        int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);



                        // Llamar al procedimiento almacenado para insertar la venta
                        using (SqlCommand comando3 = new SqlCommand("InsertarVenta", conexion3))
                        {
                            comando3.CommandType = CommandType.StoredProcedure;

                            // Asignar los parámetros
                            comando3.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                            comando3.Parameters.AddWithValue("@Cantidad", cantidad);
                            comando3.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                            comando3.Parameters.AddWithValue("@Total", total);
                            comando3.Parameters.AddWithValue("@IdCliente", idCliente);
                            //comando3.Parameters.AddWithValue("@FechaVenta", fechaVenta);

                            // Ejecutar el procedimiento almacenado
                            comando3.ExecuteNonQuery();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void LlenarTablaProductos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT * FROM productos";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvProductos.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al llenar la tabla de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarIDC();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count > 0)
            {
                dgvCarrito.Rows.RemoveAt(dgvCarrito.Rows.Count - 1);
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear la tabla PDF
                PdfPTable pdfTable = new PdfPTable(dgvCarrito.ColumnCount);
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;
                pdfTable.WidthPercentage = 70;

                // Agregar fila de encabezado
                foreach (DataGridViewColumn column in dgvCarrito.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                // Agregar filas de datos
                foreach (DataGridViewRow row in dgvCarrito.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }

                // Exportar a PDF
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";
                string filePath = Path.Combine(folderPath, "Factura.pdf");

                try
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                    }

                    MessageBox.Show("Los datos se han exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            if (dgvCarrito.Rows.Count > 0)
            {
                dgvCarrito.Rows.RemoveAt(dgvCarrito.Rows.Count - 1);
            }
            else
            {

            }

        }
    }

}
