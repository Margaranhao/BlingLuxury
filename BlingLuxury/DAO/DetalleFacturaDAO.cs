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
    class DetalleFacturaDAO : CRUD<DetalleFactura>
    {
        private static DetalleFacturaDAO detallefacturaDAO;
        protected string sql;

        public DetalleFacturaDAO()
        {

        }

        public static DetalleFacturaDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (detallefacturaDAO == null)
                detallefacturaDAO = new DetalleFacturaDAO();
            return detallefacturaDAO;
        }
        public void Actualizar(int id, DetalleFactura t) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE detalle_factura SET cantida = '" + t.cantidad + "', precio ='" + t.precio + "', id_factura ='" + t.id_factura + "',id_inventario = '" + t.id_inventario + "' WHERE id > 0 AND id = '" + id + "';";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DetalleFactura Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    DetalleFactura detallefactura;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
<<<<<<< HEAD
                                detallefactura = new DetalleFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2),new Factura(reader.GetInt32(3), reader.GetDateTime(4),reader.GetDouble(5), new Cliente(reader.GetString(6), reader.GetString(7), reader.GetString(8), new Rango(reader.GetString(9)), new Municipio(reader.GetString(10), new Localidad(reader.GetString(11), new CodigoPostal(reader.GetString(12)))), new Usuario(reader.GetString(13), reader.GetString(14), reader.GetString(15), new Nivel(reader.GetString(16)))), new DestinoEnvio(reader.GetDouble(17), reader.GetDouble(18), new Localidad(reader.GetString(19), new CodigoPostal(reader.GetString(20))), new TipoEnvio(reader.GetString(21), reader.GetDateTime(22))), new Usuario(reader.GetString(23), reader.GetString(24),reader.GetString(25), new Nivel(reader.GetString(26)))),new Inventario(reader.GetDateTime(27), reader.GetInt32(28), new Producto(reader.GetInt32(29), reader.GetInt32(30)), new Usuario(reader.GetString(36), reader.GetString(37), reader.GetString(38), new Nivel(reader.GetString(39)))));
=======
                                detallefactura = new DetalleFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2),new Factura(),new Inventario());
>>>>>>> origin/Registro
                                return detallefactura;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new DetalleFactura();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new DetalleFactura();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, DetalleFactura t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(DetalleFactura t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO detalle_factura(cantidad, precio, id_factura, id_inventario)VALUES('" + t.cantidad + "','" + t.precio + "','" + t.id_factura + "','" + t.id_inventario + "');";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DetalleFactura> Listar(string query) //Se recibe el query de busqueda
        {
            List<DetalleFactura> detallefacturaLista = new List<DetalleFactura>();
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
<<<<<<< HEAD
                                detallefacturaLista.Add(new DetalleFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), new Factura(reader.GetInt32(3), reader.GetDateTime(4), reader.GetDouble(5), new Cliente(reader.GetString(6), reader.GetString(7), reader.GetString(8), new Rango(reader.GetString(9)), new Municipio(reader.GetString(10), new Localidad(reader.GetString(11), new CodigoPostal(reader.GetString(12)))), new Usuario(reader.GetString(13), reader.GetString(14), reader.GetString(15), new Nivel(reader.GetString(16)))), new DestinoEnvio(reader.GetDouble(17), reader.GetDouble(18), new Localidad(reader.GetString(19), new CodigoPostal(reader.GetString(20))), new TipoEnvio(reader.GetString(21), reader.GetDateTime(22))), new Usuario(reader.GetString(23), reader.GetString(24), reader.GetString(25), new Nivel(reader.GetString(26)))), new Inventario(reader.GetDateTime(27), reader.GetInt32(28), new Producto(reader.GetInt32(29), reader.GetInt32(30)), new Usuario(reader.GetString(36), reader.GetString(37), reader.GetString(38), new Nivel(reader.GetString(39))))));
=======
                                detallefacturaLista.Add(new DetalleFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), new Factura(), new Inventario()));
>>>>>>> origin/Registro
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return detallefacturaLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return detallefacturaLista;
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
