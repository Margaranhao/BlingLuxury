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
    public class EntidadFederativaDAO : CRUD<EntidadFederativa>
    {
        private static EntidadFederativaDAO entidadfederativaDAO;
        protected string sql;

        public EntidadFederativaDAO()
        {

        }

        public static EntidadFederativaDAO getInstance() //Evita que la clase se instancie más de una vez
        {
            if (entidadfederativaDAO == null)
                entidadfederativaDAO = new EntidadFederativaDAO();
            return entidadfederativaDAO;
        }
        public void Actualizar(EntidadFederativa t, int id) //Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE entidad_federativa SET nombre = '" + t.nombre + "' WHERE id > 0 AND id = '" + id + "';";
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

        public EntidadFederativa Buscar(string query) //Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    EntidadFederativa entidadfederativa;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                                entidadfederativa = new EntidadFederativa(reader.GetInt32(0), reader.GetString(1));
                                return entidadfederativa;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new EntidadFederativa();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new EntidadFederativa();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, EntidadFederativa t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(EntidadFederativa t) // Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO entidad_federativa(nombre)VALUES('" + t.nombre + "');";
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

        public List<EntidadFederativa> Listar(string query) //Se recibe el query de busqueda
        {
            List<EntidadFederativa> entidadfederativaLista = new List<EntidadFederativa>();
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
                                entidadfederativaLista.Add(new EntidadFederativa(reader.GetInt32(0), reader.GetString(1)));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return entidadfederativaLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return entidadfederativaLista;
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
