using System.Data;
using System.Data.SqlClient;

namespace Parcial_2
{
    public partial class frm_usuario : Form
    {
        // 1. Declaramos la conexión y la posición para navegar
        Conexion_base_datos conexion = new Conexion_base_datos();
        private int posicion = 0;

        // 2. Método auxiliar para mostrar los registros en las cajas de texto
        private void mostrarRegistro()
        {
            if (conexion.ds != null && conexion.ds.Tables["usuarios_usss077326"].Rows.Count > 0)
            {
                System.Data.DataRow fila = conexion.ds.Tables["usuarios_usss077326"].Rows[posicion];
                txtUsuario.Text = fila["usuario"].ToString();
                txtClave.Text = fila["clave"].ToString();
            }
        }
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario tenga entre 6 y 16 caracteres
            if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
            {
                MessageBox.Show("El usuario debe tener como mínimo 6 caracteres y máximo 16.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // 2. Validar que la clave y la confirmación sean exactamente iguales
            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Verifique por favor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return;
            }

            // 3. Validar que la contraseña contenga obligatoriamente letras y números
            bool tieneLetras = txtClave.Text.Any(char.IsLetter);
            bool tieneNumeros = txtClave.Text.Any(char.IsDigit);

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La contraseña debe llevar letras y números obligatoriamente.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            // Si pasa todas las validaciones con éxito, se procede a guardar el registro
            MessageBox.Show("¡Validaciones correctas! Datos listos para guardar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frm_usuario_Load(object sender, EventArgs e)
        {
            conexion.crearDs(); // Carga la conexión y los datos
            posicion = 0;       // Arranca en el primer registro
            mostrarRegistro();  // Muestra el primer registro en pantalla
        }
        private void btnPrimerUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarRegistro();
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarRegistro();
            }
            else
            {
                MessageBox.Show("Estás en el primer registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            int totalRegistros = conexion.ds.Tables["usuarios_usss077326"].Rows.Count;
            if (posicion < totalRegistros - 1)
            {
                posicion++;
                mostrarRegistro();
            }
            else
            {
                MessageBox.Show("Estás en el último registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            int totalRegistros = conexion.ds.Tables["usuarios_usss077326"].Rows.Count;
            if (totalRegistros > 0)
            {
                posicion = totalRegistros - 1;
                mostrarRegistro();
            }
        }
        private void CargarDatos()
        {
            try
            {
                // Usa la misma cadena de conexión que te funcionó en tu clase o directamente aquí
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM usuarios_usss077326";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt; // Asegúrate de que tu DataGridView se llame dataGridView1 o cámbialo por su nombre real
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO usuarios_usss077326 (Usuario, Clave, Nombre, Direccion, Telefono) VALUES (@Usuario, @Clave, @Nombre, @Direccion, @Telefono)";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario agregado correctamente!");
                    }
                }
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada en la tabla
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona un usuario de la tabla.");
                    return;
                }

                // Extraemos el IdUsuario directamente de la celda de la fila seleccionada
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value);

                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "UPDATE usuarios_usss077326 SET Usuario = @Usuario, Clave = @Clave, Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario modificado correctamente!");
                    }
                }
                CargarDatos(); // Refresca la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada en la tabla
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona un usuario de la tabla.");
                    return;
                }

                // Extraemos el IdUsuario directamente de la celda de la fila seleccionada
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value);

                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "DELETE FROM usuarios_usss077326 WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario eliminado correctamente!");
                    }
                }
                CargarDatos(); // Refresca la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}