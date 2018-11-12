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
                                Modelo productoIdModelo = new Modelo(reader.GetInt32(3), reader.GetString(4));
                                Marca modeloIdMarca = new Marca(reader.GetInt32(5), reader.GetString(6));
                                PrecioAdquisicion productoIdPrecio_adquisicion = new PrecioAdquisicion(reader.GetInt32(7), reader.GetDouble(8));
                                Color productoIdColor = new Color(reader.GetInt32(9), reader.GetString(10));
                                Categoria productoIdCategoria = new Categoria(reader.GetInt32(11), reader.GetString(12));

                                //registroproductoLista.Add(new RegistroProducto(idProducto, codigoProducto, pesoProducto, productoIdModelo, modeloIdMarca,
                                //                          productoIdPrecio_adquisicion, productoIdColor, productoIdCategoria));

                                registroproductoLista.Add(new RegistroProducto(idProducto, codigoProducto, pesoProducto, productoIdModelo, modeloIdMarca,
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
