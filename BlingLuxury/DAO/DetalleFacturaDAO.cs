using BlingLuxury.Clases;
using BlingLuxury.CONEXION;
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

        public static DetalleFacturaDAO getInstance()
        {
            if (detallefacturaDAO == null)
                detallefacturaDAO = new DetalleFacturaDAO();
            return detallefacturaDAO;
        }
        public void Actualizar(int id, DetalleFactura t)
        {
            try
            {
                sql = "UPDATE detalle_factura SET cantida = '" + t.cantidad + "' WHERE id > 0 AND id = '" + id + "';";
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

        public DetalleFactura Buscar(string query)
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
                                detallefactura = new DetalleFactura();// reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
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

        public void Insertar(DetalleFactura t)
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

        public List<DetalleFactura> Listar(string query)
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
                                detallefacturaLista.Add(new DetalleFactura());// reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3)));
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
