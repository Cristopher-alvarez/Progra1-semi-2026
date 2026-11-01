using System.Data;
using System.Data.SqlClient;

namespace Parcial_2
{
    public partial class frm_usuario : Form
    {
        Conexion_base_datos conexion = new Conexion_base_datos();
        private int posicion = 0;

        private void mostrarRegistro()
        {
            if (conexion.ds != null && conexion.ds.Tables["usuarios_usss077326"].Rows.Count > 0)
            {
                if (posicion >= 0 && posicion < conexion.ds.Tables["usuarios_usss077326"].Rows.Count)
                {
                    System.Data.DataRow fila = conexion.ds.Tables["usuarios_usss077326"].Rows[posicion];

                    txtUsuario.Text = fila["Usuario"]?.ToString() ?? "";
                    txtClave.Text = fila["Clave"]?.ToString() ?? "";
                    txtConfirmarClave.Text = fila["Clave"]?.ToString() ?? "";
                    txtNombre.Text = fila["Nombre"]?.ToString() ?? "";
                    txtDireccion.Text = fila["Direccion"]?.ToString() ?? "";
                    txtTelefono.Text = fila["Telefono"]?.ToString() ?? "";

                    if (dataGridView1.Rows.Count > posicion)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[posicion].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[posicion].Cells[0];
                    }
                }
            }
        }
        public frm_usuario()
        {
            InitializeComponent();

            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            btnPrimerUsuario.Click += btnPrimerUsuario_Click;
            btnAnteriorUsuario.Click += btnAnteriorUsuario_Click;
            btnSiguienteUsuario.Click += btnSiguienteUsuario_Click;
            btnUltimoUsuario.Click += btnUltimoUsuario_Click;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
            {
                MessageBox.Show("El usuario debe tener como mínimo 6 caracteres y máximo 16.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Verifique por favor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return;
            }

            bool tieneLetras = txtClave.Text.Any(char.IsLetter);
            bool tieneNumeros = txtClave.Text.Any(char.IsDigit);

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La contraseña debe llevar letras y números obligatoriamente.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;";
                using (SqlConnection conexionSql = new SqlConnection(cadenaConexion))
                {
                    conexionSql.Open();
                    string query = "INSERT INTO usuarios_usss077326 (Usuario, Clave, Nombre, Direccion, Telefono) VALUES (@Usuario, @Clave, @Nombre, @Direccion, @Telefono)";

                    using (SqlCommand cmd = new SqlCommand(query, conexionSql))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario agregado y guardado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
        private void frm_usuario_Load(object sender, EventArgs e)
        {
            conexion.crearDs();
            posicion = 0;
            mostrarRegistro();
            CargarDatos();
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
            if (conexion.ds != null && conexion.ds.Tables["usuarios_usss077326"].Rows.Count > 0)
            {
                if (posicion < conexion.ds.Tables["usuarios_usss077326"].Rows.Count - 1)
                {
                    posicion++;
                    mostrarRegistro();
                }
                else
                {
                    MessageBox.Show("Estás en el último registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            if (conexion.ds != null && conexion.ds.Tables["usuarios_usss077326"].Rows.Count > 0)
            {
                posicion = conexion.ds.Tables["usuarios_usss077326"].Rows.Count - 1;
                mostrarRegistro();
            }
        }
        private void CargarDatos()
        {
            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexionSql = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM usuarios_usss077326";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexionSql);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataGridView1.DataSource = dt;
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
                if (txtUsuario.Text.Length < 6 || txtUsuario.Text.Length > 16)
                {
                    MessageBox.Show("El usuario debe tener como mínimo 6 caracteres y máximo 16.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (txtClave.Text != txtConfirmarClave.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden. Verifique por favor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmarClave.Focus();
                    return;
                }

                bool tieneLetras = txtClave.Text.Any(char.IsLetter);
                bool tieneNumeros = txtClave.Text.Any(char.IsDigit);

                if (!tieneLetras || !tieneNumeros)
                {
                    MessageBox.Show("La contraseña debe llevar letras y números obligatoriamente.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                    return;
                }

                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexionSql = new SqlConnection(cadenaConexion))
                {
                    conexionSql.Open();
                    string query = "INSERT INTO usuarios_usss077326 (Usuario, Clave, Nombre, Direccion, Telefono) VALUES (@Usuario, @Clave, @Nombre, @Direccion, @Telefono)";

                    using (SqlCommand cmd = new SqlCommand(query, conexionSql))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario agregado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                CargarDatos();
                conexion.crearDs();
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
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["IdUsuario"].Value == DBNull.Value || dataGridView1.CurrentRow.Cells["IdUsuario"].Value == null)
                {
                    MessageBox.Show("Por favor, selecciona un usuario válido de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value);

                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;";

                using (SqlConnection conexionSql = new SqlConnection(cadenaConexion))
                {
                    conexionSql.Open();
                    string query = "UPDATE usuarios_usss077326 SET Usuario = @Usuario, Clave = @Clave, Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand cmd = new SqlCommand(query, conexionSql))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Usuario modificado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                CargarDatos();
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
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["IdUsuario"].Value == DBNull.Value || dataGridView1.CurrentRow.Cells["IdUsuario"].Value == null)
                {
                    MessageBox.Show("Por favor, selecciona un usuario válido de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEliminado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdUsuario"].Value);

                    string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;";

                    using (SqlConnection conexionSql = new SqlConnection(cadenaConexion))
                    {
                        conexionSql.Open();
                        string queryDelete = "DELETE FROM usuarios_usss077326 WHERE IdUsuario = @IdUsuario";

                        using (SqlCommand cmdDelete = new SqlCommand(queryDelete, conexionSql))
                        {
                            cmdDelete.Parameters.AddWithValue("@IdUsuario", idEliminado);
                            cmdDelete.ExecuteNonQuery();
                        }

                        MessageBox.Show("¡Usuario eliminado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1) 
            {
                posicion = e.RowIndex; 

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtUsuario.Text = row.Cells["Usuario"].Value?.ToString() ?? "";
                txtClave.Text = row.Cells["Clave"].Value?.ToString() ?? "";
                txtConfirmarClave.Text = row.Cells["Clave"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value != DBNull.Value && dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtUsuario.Text = row.Cells["Usuario"].Value?.ToString() ?? "";
                txtClave.Text = row.Cells["Clave"].Value?.ToString() ?? "";
                txtConfirmarClave.Text = row.Cells["Clave"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = row.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource is DataTable tabla)
                {
                    string filtro = txtBuscarUsuario.Text.Trim().Replace("'", "''");

                    tabla.DefaultView.RowFilter = $"Usuario LIKE '%{filtro}%' OR Nombre LIKE '%{filtro}%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar el filtro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}