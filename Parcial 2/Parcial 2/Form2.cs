using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string queryVerificar = "SELECT COUNT(*) FROM usuarios_usss077326";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion))
                    {
                        int totalRegistros = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                        if (totalRegistros == 0)
                        {
                            string queryInsertar = "INSERT INTO usuarios_usss077326 (Usuario, Clave, Nombre, Direccion, Telefono) VALUES ('admin', '1234', 'Admin', 'Sistema', '00000000')";
                            using (SqlCommand cmdInsertar = new SqlCommand(queryInsertar, conexion))
                            {
                                cmdInsertar.ExecuteNonQuery();
                            }
                        }
                    }

                    string queryLogin = "SELECT COUNT(*) FROM usuarios_usss077326 WHERE RTRIM(Usuario) = @Usuario AND RTRIM(Clave) = @Clave";
                    using (SqlCommand cmdLogin = new SqlCommand(queryLogin, conexion))
                    {
                        cmdLogin.Parameters.AddWithValue("@Usuario", txtUsuarioLogin.Text.Trim());
                        cmdLogin.Parameters.AddWithValue("@Clave", txtClaveLogin.Text.Trim());

                        int resultado = Convert.ToInt32(cmdLogin.ExecuteScalar());

                        if (resultado > 0)
                        {
                            MessageBox.Show("¡Bienvenido al sistema!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frm_usuario principal = new frm_usuario();
                            principal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
