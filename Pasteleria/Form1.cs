

using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

using System.Drawing;
using Conexion;
using System.Data.SqlClient;

namespace Pasteleria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = false;
            btnUser.Visible = true;

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = SystemColors.Control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int cont = 3;
        Conectar con;
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    con = new Conectar(txtEmail.Text, txtPass.Text);

                    if (con.connect.State == ConnectionState.Open)
                    {


                        VerificarRoles(txtEmail.Text);



                    }
                    else
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPass.Text))
                            {
                                MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                con = new Conectar(txtEmail.Text, txtPass.Text);

                                if (con.connect.State == ConnectionState.Open)
                                {
                                   
                                    VerificarRoles(txtEmail.Text);
                                }
                                else
                                {
                                    cont--;

                                    txtEmail.Clear();
                                    txtPass.Clear();

                                    if (cont == 0)
                                    {
                                        Cursor.Current = Cursors.Default;
                                        MessageBox.Show("Tres intentos fallidos. Cerrando la aplicación.", "Intentos Excedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Close();
                                    }
                                    else
                                    {
                                        Cursor.Current = Cursors.Default;
                                        MessageBox.Show($"Credenciales incorrectas. Te quedan {cont} intentos.", "Intento Fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al verificar las credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                    }
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
           
            
        }

        private void VerificarRoles(string usuario)
        {
            // Consulta para obtener roles del usuario
            string query = "SELECT r.name " +
                "FROM sys.server_role_members m " +
                "INNER JOIN sys.server_principals p ON m.member_principal_id = p.principal_id " +
                "INNER JOIN sys.server_principals r ON m.role_principal_id = r.principal_id " +
                "WHERE p.name = @Usuario";

            using (SqlCommand cmd = new SqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string rol = reader["name"].ToString();
                        // Abre el formulario correspondiente según el rol
                        if (rol.Equals("sysadmin"))
                        {
                            AbrirFormularioSysAdmin();
                            return;
                        }
                        else if (rol.Equals("processadmin"))
                        {
                            AbrirFormularioDbDdlAdmin();
                            return;
                        }
                        // Agrega más condiciones según sea necesario para otros roles
                    }
                }
            }
        }

        private void AbrirFormularioSysAdmin()
        {
            Admin A = new Admin();
            A.Show();
            this.Hide();
        }

        private void AbrirFormularioDbDdlAdmin()
        {
            Usuarios u = new Usuarios();
            u.Show();
            this.Hide();
        }
    }
}