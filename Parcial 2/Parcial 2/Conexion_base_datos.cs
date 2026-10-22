using System;
using System.Data;
using System.Data.SqlClient;

namespace Parcial_2
{
    internal class Conexion_base_datos
    {
        // Agregamos el signo '?' para evitar advertencias de valores nulos
        public SqlDataAdapter? adaptador;
        public DataSet? ds;
        public SqlConnection? conexion;

        // 1. Método para crear y configurar el DataSet de la tabla usuarios
        public void crearDs()
        {
            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;"; conexion = new SqlConnection(cadenaConexion);

                // 2. Creamos el comando explícito con la consulta y la conexión
                SqlCommand comando = new SqlCommand("SELECT * FROM usuarios_usss077326", conexion);

                // 3. Pasamos el comando al adaptador
                adaptador = new SqlDataAdapter(comando);

                // 4. Llenamos el DataSet
                ds = new DataSet();
                adaptador.Fill(ds, "usuarios_usss077326");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar o crear DataSet: " + ex.Message);
            }
        }        

        // 2. Método de mantenimiento obligatorio exigido por el examen
        public void mantenimiento_usuarios_usss077326()
        {
            this.procesar();
        }

        // 3. Método procesar para actualizar los cambios en la base de datos
        public void procesar()
        {
            try
            {
                if (adaptador != null && ds != null)
                {
                    SqlCommandBuilder constructor = new SqlCommandBuilder(adaptador);
                    adaptador.Update(ds, "usuarios_usss077326");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al procesar en la base de datos: " + ex.Message);
            }
        }
    }
}