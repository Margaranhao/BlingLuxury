using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;

namespace BlingLuxury.DAO
{
    public class PromocionDAO : CRUD<Promocion>
    {
        private static PromocionDAO promocionDAO;
        protected string sql;
        public PromocionDAO()
        {

        }
        public static PromocionDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (promocionDAO == null)
                promocionDAO = new PromocionDAO();
            return promocionDAO;
        }
        public void Actualizar(Promocion t, int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE promocion SET fecha_inicio = '" + t.fechaInicio + "', fecha_fin ='" + t.fechaFin + "', oferta ='" + t.oferta + "', id_producto = '" + t.id_producto + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Promocion Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Promocion promocion;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                promocion = new Promocion(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetBoolean(3), new Producto(reader.GetString(4),reader.GetDouble(5),new Modelo(reader.GetString(6), new Marca(reader.GetString(7))), new PrecioAdquisicion(reader.GetDouble(8)), new Color(reader.GetString(9)), new Categoria(reader.GetString(10))));
                                return promocion;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Promocion();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Promocion();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Promocion t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Promocion t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO promocion(fecha_inicio, fecha_fin, oferta, id_producto) VALUES ('" + t.fechaInicio + "','" + t.fechaFin + "''" + t.oferta + "','" + t.id_producto + "');";
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

        public List<Promocion> Listar(string query)
        {
            List<Promocion> promocionLista = new List<Promocion>();
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
                                promocionLista.Add(new Promocion(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2), reader.GetBoolean(3), new Producto(reader.GetString(4), reader.GetDouble(5), new Modelo(reader.GetString(6), new Marca(reader.GetString(7))), new PrecioAdquisicion(reader.GetDouble(8)), new Color(reader.GetString(9)), new Categoria(reader.GetString(10)))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return promocionLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return promocionLista;
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
