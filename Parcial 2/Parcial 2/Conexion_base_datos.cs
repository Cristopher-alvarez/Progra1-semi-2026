using System;
using System.Data;
using System.Data.SqlClient;

namespace Parcial_2
{
    internal class Conexion_base_datos
    {
        public SqlDataAdapter? adaptador;
        public DataSet? ds;
        public SqlConnection? conexion;

        public void crearDs()
        {
            try
            {
                string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guillermo\source\repos\Progra1-semi-2026\Parcial 2\Parcial 2\Parcia_ll.mdf;Integrated Security=True;"; conexion = new SqlConnection(cadenaConexion);

                SqlCommand comando = new SqlCommand("SELECT * FROM usuarios_usss077326", conexion);

                adaptador = new SqlDataAdapter(comando);

                ds = new DataSet();
                adaptador.Fill(ds, "usuarios_usss077326");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar o crear DataSet: " + ex.Message);
            }
        }        

        public void mantenimiento_usuarios_usss077326()
        {
            this.procesar();
        }

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