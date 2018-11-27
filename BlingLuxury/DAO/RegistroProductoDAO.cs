using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.DAO
{
    public class RegistroProductoDAO : CRUD<RegistroProducto>
    {
        private static RegistroProductoDAO registroproductoDAO;
        protected string sql;
        public RegistroProductoDAO()
        {

        }
        public static RegistroProductoDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (registroproductoDAO == null)
                registroproductoDAO = new RegistroProductoDAO();
            return registroproductoDAO;
        }
        public void Actualizar(RegistroProducto t, int id)
        {
            throw new NotImplementedException();
        }

        public RegistroProducto Buscar(string query)
        {
            throw new NotImplementedException();
        }

        public void CambiarEstado(int id, RegistroProducto t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(RegistroProducto t)
        {
            throw new NotImplementedException();
        }

        public List<RegistroProducto> Listar(string query)
        {
            List<RegistroProducto> registroproductoLista = new List<RegistroProducto>();
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    MySqlDataReader reader;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {                                
                                int idProducto = reader.GetInt32(0);
                                string codigoProducto = reader.GetString(1);
                                double pesoProducto = reader.GetDouble(2);
                                string descripcionProducto = reader.GetString(3);
                                Modelo productoIdModelo = new Modelo(reader.GetInt32(4), reader.GetString(5));
                                Marca modeloIdMarca = new Marca(reader.GetInt32(6), reader.GetString(7));
                                PrecioAdquisicion productoIdPrecio_adquisicion = new PrecioAdquisicion(reader.GetInt32(8), reader.GetDouble(9));
                                Color productoIdColor = new Color(reader.GetInt32(10), reader.GetString(11));
                                Categoria productoIdCategoria = new Categoria(reader.GetInt32(12), reader.GetString(13));                                
                                
                                registroproductoLista.Add(new RegistroProducto(idProducto, codigoProducto, pesoProducto, descripcionProducto, productoIdModelo, modeloIdMarca,
                                                          productoIdPrecio_adquisicion, productoIdColor, productoIdCategoria));                                
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroproductoLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroproductoLista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<RegistroProducto> Listar2(string query)
        {
            List<RegistroProducto> registroproductoLista = new List<RegistroProducto>();
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    MySqlDataReader reader;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //string codigoProducto = reader.GetString(1);
                                //double pesoProducto = reader.GetDouble(2);
                                int idProducto = reader.GetInt32(0);                                
                                string descripcionProducto = reader.GetString(1);
                                Modelo productoIdModelo = new Modelo(reader.GetString(2));
                                Marca modeloIdMarca = new Marca(reader.GetString(3));
                                PrecioAdquisicion productoIdPrecio_adquisicion = new PrecioAdquisicion(reader.GetDouble(4));
                                Color productoIdColor = new Color(reader.GetString(5));
                                Categoria productoIdCategoria = new Categoria(reader.GetString(6));

                                //registroproductoLista.Add(new RegistroProducto(idProducto, codigoProducto, pesoProducto, productoIdModelo, modeloIdMarca,
                                //                          productoIdPrecio_adquisicion, productoIdColor, productoIdCategoria));

                                registroproductoLista.Add(new RegistroProducto(idProducto, descripcionProducto, productoIdModelo, modeloIdMarca,
                                                          productoIdPrecio_adquisicion, productoIdColor, productoIdCategoria));

                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroproductoLista;

                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroproductoLista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
