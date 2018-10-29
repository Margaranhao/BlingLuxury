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
    public class PaqueteriaDAO : CRUD<Paqueteria>
    {
        private static PaqueteriaDAO paqueteriaDAO;
        protected string sql;
        public PaqueteriaDAO()
        {

        }
        public static PaqueteriaDAO getInstance()//evita que la clase se instancie más de una vez
        {
            if (paqueteriaDAO == null)
                paqueteriaDAO = new PaqueteriaDAO();
            return paqueteriaDAO;
        }

        public void Actualizar(Paqueteria t,int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE paqueteria SET nombre = '" + t.nombre + "', id_envio = '" + t.id_envio + "' WHERE id > 0 AND id = '" + id + "';";
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

        public Paqueteria Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Paqueteria paqueteria;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                paqueteria = new Paqueteria(reader.GetInt32(0), reader.GetString(1), new TipoEnvio(reader.GetString(2),reader.GetDateTime(3)));
                                return paqueteria;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Paqueteria();
                        }
                        else
                        {
                            // Se cierra la conecion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Paqueteria();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Paqueteria t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Paqueteria t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO paqueteria(nombre, id_envio) VALUES ('" + t.nombre + "','" + t.id_envio + "');";
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

        public List<Paqueteria> Listar(string query)
        {
            List<Paqueteria> paqueteriaLista = new List<Paqueteria>();
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
                                paqueteriaLista.Add(new Paqueteria(reader.GetInt32(0), reader.GetString(1), new TipoEnvio(reader.GetString(2), reader.GetDateTime(3))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return paqueteriaLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return paqueteriaLista;
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
