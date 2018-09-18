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
    class FacturaDAO : CRUD<Factura>
    {
        private static FacturaDAO facturaDAO;
        protected string sql;

        public FacturaDAO()
        {

        }

        public static FacturaDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (facturaDAO == null)
                facturaDAO = new FacturaDAO();
            return facturaDAO;
        }
        public void Actualizar(int id, Factura t) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE factura SET folio = '" + t.folio + "', fecha ='" + t.fecha + "', total ='" + t.total + "', id_cliente ='" + t.id_cliente + "', id_destino ='" + t.id_destino + "', id_usuario ='" + t.id_usuario + "' WHERE id > 0 AND id = '" + id + "';";
                Conexion.getInstance().setCadenaConnection();
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Factura Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Factura factura;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                               factura = new Factura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetDouble(3), new Cliente(reader.GetString(4), reader.GetString(5), reader.GetString(6), new Rango(reader.GetString(7)), new Municipio(reader.GetString(8), new Localidad(reader.GetString(9), new CodigoPostal(reader.GetString(10)))), new Usuario(reader.GetString(11), reader.GetString(12), reader.GetString(13), new Nivel(reader.GetString(14)))), new DestinoEnvio(reader.GetInt32(15), reader.GetDouble(16), reader.GetDouble(17), new Localidad(reader.GetString(18), new CodigoPostal(reader.GetString(19))), new TipoEnvio(reader.GetString(20), reader.GetDateTime(21))), new Usuario(reader.GetString(22), reader.GetString(23), reader.GetString(24), new Nivel(reader.GetString(25))));
                                return factura;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Factura();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new Factura();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Factura t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Factura t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO factura(folio, fecha, total, id_cliente, id_destino, id_usuario)VALUES('" + t.folio + "','" + t.fecha + "','" + t.total + "','" + t.id_cliente + "','" + t.id_destino + "','" + t.id_usuario + "');";
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

        public List<Factura> Listar(string query) //Se recibe el query de busqueda
        {
            List<Factura> facturaLista = new List<Factura>();
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
                                facturaLista.Add(new Factura(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2), reader.GetDouble(3), new Cliente(reader.GetString(4), reader.GetString(5), reader.GetString(6), new Rango(reader.GetString(7)), new Municipio(reader.GetString(8), new Localidad(reader.GetString(9), new CodigoPostal(reader.GetString(10)))), new Usuario(reader.GetString(11), reader.GetString(12), reader.GetString(13), new Nivel(reader.GetString(14)))), new DestinoEnvio(reader.GetInt32(15), reader.GetDouble(16), reader.GetDouble(17), new Localidad(reader.GetString(18), new CodigoPostal(reader.GetString(19))), new TipoEnvio(reader.GetString(20), reader.GetDateTime(21))), new Usuario(reader.GetString(22), reader.GetString(23), reader.GetString(24), new Nivel(reader.GetString(25)))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return facturaLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return facturaLista;
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
