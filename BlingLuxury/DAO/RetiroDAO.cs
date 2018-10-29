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
    public class RetiroDAO : CRUD<Retiro>
    {
        private static RetiroDAO retiroDAO;
        protected string sql;
        public RetiroDAO()
        {

        }
        public static RetiroDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (retiroDAO == null)
                retiroDAO = new RetiroDAO();
            return retiroDAO;
        }
        public void Actualizar(Retiro t, int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE retiro SET nombre = '" + t.fecha + "', cantidad = '" + t.cantidad + "', razon = '" + t.razon + "', id_usuario = '" + t.id_usuario + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Retiro Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Retiro retiro;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                retiro = new Retiro(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDouble(2), reader.GetString(3), new Usuario(reader.GetInt32(4),reader.GetString(5),reader.GetString(6),reader.GetString(7),new Nivel(reader.GetInt32(8),reader.GetString(9))));
                                return retiro;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Retiro();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Retiro();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Retiro t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Retiro t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO retiro(fecha, cantidad, razon, id_usuario) VALUES ('" + t.fecha + "','" + t.cantidad + "''" + t.razon + "','" + t.id_usuario + "');";
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


        public List<Retiro> Listar(string query)
        {
            List<Retiro> retiroLista = new List<Retiro>();
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
                                retiroLista.Add(new Retiro(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDouble(2), reader.GetString(3), new Usuario(reader.GetString(4), reader.GetString(5), reader.GetString(6), new Nivel(reader.GetString(7)))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return retiroLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return retiroLista;
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
