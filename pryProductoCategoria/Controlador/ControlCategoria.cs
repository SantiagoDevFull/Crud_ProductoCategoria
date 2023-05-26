using MySql.Data.MySqlClient;
using pryProductoCategoria.Config;
using pryProductoCategoria.Interfaces;
using pryProductoCategoria.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Controlador
{
    public class ControlCategoria : Icategoria
    {

        private MySqlConnection cn = null;
        private MySqlCommand st = null;
        private MySqlDataReader rs = null;

        public int ActualizarCategoria(Categoria c)
        {

            int res = 0;

            try
            {
                cn = MySQLConexion.getConexion();
                string consulta = "UPDATE categoria SET nomCat=@nomCat,estadoCat=@estadoCat WHERE idCat=@idCat";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@nomCat", c.NomCat);
                st.Parameters.AddWithValue("@estadoCat", c.EstadoCat);
                st.Parameters.AddWithValue("@idCat", c.IdCat);

                res = st.ExecuteNonQuery();
            }catch(SqlException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }

                if (rs != null)
                {
                    rs.Close();
                }
            }

            return res;

        }

        public int AgregarCategoria(Categoria c)
        {

            int res = 0;

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "INSERT INTO categoria(nomCat,estadoCat) VALUES (@nomCat,@estadoCat)";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@nomCat", c.NomCat);
                st.Parameters.AddWithValue("@estadoCat", c.EstadoCat);

                res = st.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }

                if (rs != null)
                {
                    rs.Close();
                }
               
            }

            return res;

        }

        public List<Producto> BuscarProductos(int idCat)
        {

            List<Producto> lista = new List<Producto>();

            try
            {
                cn = MySQLConexion.getConexion();
                string consulta = "SELECT*FROM producto WHERE idCat=@idCat;";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@idCat", idCat);

                rs = st.ExecuteReader();

                while (rs.Read())
                {
                    Producto p = new Producto();
                    p.IdPro = rs.GetInt32(0);
                    p.NomPro = rs.GetString(1);
                    p.StockPro = rs.GetInt32(2);
                    p.PrecioPro = rs.GetDouble(3);
                    lista.Add(p);
                }
            }catch(MySqlException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
                if (rs != null)
                {
                    rs.Close();
                }
            }
            return lista;
        }

        public int EliminarCategoria(int id)
        {

            int res = 0;

            try
            {

                cn=MySQLConexion.getConexion();
                string consulta = "DELETE FROM categoria WHERE idCat=@idCat";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@idCat", id);

                res=st.ExecuteNonQuery();

            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }

                if (rs != null)
                {
                    rs.Close();
                }
            }

            return res;

        }

        public List<Categoria> ListarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();

                try {
                    cn = MySQLConexion.getConexion();
                    string consulta = "SELECT c.idCat,c.nomCat,c.estadoCat,\r\n" +
                        "(SELECT COUNT(*) FROM producto p WHERE p.idCat=c.idCat)\r\nFROM categoria c";
                    st = new MySqlCommand(consulta, cn);
                    rs = st.ExecuteReader();

                        while (rs.Read())
                        {
                            Categoria c = new Categoria();
                            c.IdCat = rs.GetInt32(0);
                            c.NomCat = rs.GetString(1);
                            c.EstadoCat = rs.GetString(2);
                            c.NumProductos = rs.GetInt32(3);
                            lista.Add(c);
                        }
                 
                }catch(SqlException ex){Console.WriteLine(ex.Message);
                }finally{
                    if (cn != null)
                    {
                        cn.Close();
                    }

                    if (rs != null)
                    {
                        rs.Close();
                    }
                }
                return lista;
        }

        public int RetornarCodigoCategoria()
        {

            int res = 0;

            try
            {
                cn = MySQLConexion.getConexion();
                string consulta = "SELECT AUTO_INCREMENT\r\nFROM  INFORMATION_SCHEMA.TABLES\r\n" +
                    "WHERE TABLE_SCHEMA = 'bdproductocategoria'\r\nAND   " +
                    "TABLE_NAME   = 'categoria';\r\n";
                st = new MySqlCommand(consulta, cn);
                rs = st.ExecuteReader();

                if (rs.Read())
                {
                    res = rs.GetInt32(0);
                }
                
                
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }

                if (rs != null)
                {
                    rs.Close();
                }
            }

            return res;

        }


    }
}
