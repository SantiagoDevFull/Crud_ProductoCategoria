using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProductoCategoria.Config
{
    public class MySQLConexion
    {
        public static MySqlConnection getConexion()
        {
            MySqlConnection cn = null;
            try
            {
                 string servidor = "localhost";
                 string bd = "bdproductocategoria";
                 string usuario = "root";
                 string password = "";
                 string puerto = "3306";

                string cadena = "server=" + servidor + ";" +
                    "port=" + puerto + ";" + "user id=" +
                    usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

                cn=new MySqlConnection(cadena) ;
                cn.Open();
                Console.WriteLine("Conexion ok");

            }catch(MySqlException ex)
            {
                Console.WriteLine("No se pudo conectar a la bd con error: "+ex.ToString());
            }
            return cn;
        }



    }
}
