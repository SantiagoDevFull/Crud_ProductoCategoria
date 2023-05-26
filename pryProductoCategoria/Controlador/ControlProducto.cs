using MySql.Data.MySqlClient;
using pryProductoCategoria.Config;
using pryProductoCategoria.Interfaces;
using pryProductoCategoria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProductoCategoria.Controlador
{
    public class ControlProducto : Iproducto
    {

        private MySqlConnection cn = null;
        private MySqlCommand st = null;
        private MySqlDataReader rs = null;


        public int ActualizarProducto(Producto p)
        {

            int res = 0;

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "UPDATE producto SET nomPro=@nomPro,stockPro=@stockPro," +
                    "precioPro=@precioPro,idCat=@idCat WHERE idPro=@idPro";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@nomPro", p.NomPro);
                st.Parameters.AddWithValue("@stockPro", p.StockPro);
                st.Parameters.AddWithValue("@precioPro", p.PrecioPro);
                st.Parameters.AddWithValue("@idCat", p.Categoria.IdCat);
                st.Parameters.AddWithValue("@idPro", p.IdPro);

                res = st.ExecuteNonQuery();
            }
            catch(MySqlException ex)
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

        public int AgregarProducto(Producto p)
        {

            int res = 0;

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "INSERT INTO producto(nomPro,stockPro,precioPro,idCat) " +
                    "VALUES (@nomPro,@stockPro,@precioPro,@idCat)";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@nomPro", p.NomPro);
                st.Parameters.AddWithValue("@stockPro", p.StockPro);
                st.Parameters.AddWithValue("@precioPro", p.PrecioPro);
                st.Parameters.AddWithValue("@idCat", p.Categoria.IdCat);

                res = st.ExecuteNonQuery();

            }
            catch(MySqlException ex)
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

        public int EliminarProducto(int idPro)
        {

            int res = 0;

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "DELETE FROM producto WHERE idPro=@idPro";
                st = new MySqlCommand(consulta, cn);

                st.Parameters.AddWithValue("@idPro", idPro);

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

        public List<Producto> ListarProducto()
        {
            
            List<Producto>lista=new List<Producto>();

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "SELECT p.idPro,p.nomPro,p.stockPro,p.precioPro,p.idCat,c.nomCat,c.estadoCat FROM producto p " +
                    "INNER JOIN categoria c ON (p.idCat=c.idCat)";
                st = new MySqlCommand(consulta, cn);
                rs=st.ExecuteReader();

                while (rs.Read())
                {
                    Producto p = new Producto();
                    p.IdPro = rs.GetInt32(0);
                    p.NomPro = rs.GetString(1);
                    p.StockPro = rs.GetInt32(2);
                    p.PrecioPro = rs.GetDouble(3);

                    Categoria c = new Categoria();
                    c.IdCat = rs.GetInt32(4);
                    c.NomCat = rs.GetString(5);
                    c.EstadoCat = rs.GetString(6);

                    p.Categoria = c;

                    lista.Add(p);
                }

            }
            catch(MySqlException ex)
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

            return lista;
            

        }

        public int RetornarCodigoProducto()
        {

            int res = 0;

            try
            {

                cn = MySQLConexion.getConexion();
                string consulta = "SELECT AUTO_INCREMENT " +
                    "FROM  INFORMATION_SCHEMA.TABLES " +
                    "WHERE TABLE_SCHEMA = 'bdproductocategoria' " +
                    "AND   TABLE_NAME   = 'producto';";
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
