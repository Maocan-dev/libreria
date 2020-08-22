using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    class conexion
    {
        private static MySqlConnection miconexion()
        {
            string servidor = "localhost";
            string bd = "libreria";
            string usuario = "root";
            string password = "";
            string cadenaconexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password;
            try
            {
                MySqlConnection conectabd = new MySqlConnection(cadenaconexion);
                return conectabd;
            }
            catch (MySqlException ex)
            {
                Console.Write("Error :" + ex.Message);
                return null;
            }
        }
        public static String ejecutaquery(String accion,String sentencia)
        {
            String mensaje = null;
            switch (accion)
            {
                case "insertar":
                    mensaje = "Registro agregado con exito";
                    break;
                case "modificar":
                    mensaje = "Registro modificado con exito";
                    break;
                case "eliminar":
                    mensaje = "Registro eliminado con exito";
                    break;
            }

            MySqlConnection conectabd = miconexion();
            conectabd.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sentencia, conectabd);
                comando.ExecuteNonQuery();
             }
            catch (MySqlException ex)
            {
                Console.Write("error : " + ex.Message);
                mensaje = "No se ha podido realizar la accion: " + ex.Message;
            }
            finally
            {
                conectabd.Close();
            }

            return mensaje;
        }
        public static DataTable recuperadatos(String sentencia)
        {
            DataTable datos = new DataTable();
            MySqlDataReader lector = null;
            MySqlConnection conectabd = miconexion();
            conectabd.Open();
            try {
                MySqlCommand comando = new MySqlCommand(sentencia,conectabd);
                lector = comando.ExecuteReader();
                datos.Load(lector);
                return datos;
            }
            catch (MySqlException ex){
                Console.Write("error : " + ex.Message);
                return null;
            }
            finally {
                conectabd.Close();
            }
            
        }
    }
}
