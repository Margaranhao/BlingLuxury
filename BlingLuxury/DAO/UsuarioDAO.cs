using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Clases;
using BlingLuxury.Connection;
using BlingLuxury.CRUD;
using System.Data;

namespace BlingLuxury.DAO
{
   public class UsuarioDAO:CRUD<Usuario>
    {
        private static UsuarioDAO usuarioDAO;
        protected string sql;
        public UsuarioDAO()
        {

        }
        public static UsuarioDAO getInstance()//evita que a clase se instancie más de una vez
        {
            if (usuarioDAO == null)
                usuarioDAO = new UsuarioDAO();
            return usuarioDAO;
        }
        public void Actualizar(Usuario t, int id)//Actualizar se recibe en la clase a actualizar y el indice de busqueda
        {
            try
            {
                sql = "UPDATE usuario SET nombre = '" + t.nombre + "', nick ='" + t.nick + "', pass='" + t.pass + "', id_nivel=" + t.id_nivel.id + " WHERE id > 0 AND id = " + id + ";";
                Conexion.getInstance().setCadenaConnection(); 
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.getInstance().getConnection());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Conexion.getInstance().getConnection().Close();
            }
           catch (Exception)
            {
                //throw new Exception(ex.Message);
            }
        }
        public Usuario Buscar(string query)//Recibe un query de busqueda
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    // Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    Usuario usuario;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//se recorre cada elemento que obtuvo el reader
                            {
                                // Se crea un nuevo objeto de la clase y se retorna
                                usuario = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),new Nivel());
                                return usuario;
                            }
                            // Se cierra la conexion y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new Usuario();
                        }
                        else
                        {
                            // Se cierra la conexion y se retorna un objeto de la clase vacio 
                            Conexion.getInstance().getConnection().Close();
                            return new Usuario();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, Usuario t)
        {
            throw new NotImplementedException();
        }


        /*   por si el cliente
        public void CambiarEstado(int id, Usuario t)//Actualizar se recibe la clase a actualizar y el indice de busqueda
        {
            try
            {
                if (t.estado)
                {
                    sql = "UPDATE usuario SET estado = true WHERE id > 0 AND id ='" + id + "';";
                }
                else
                {
                    sql = "UPDATE usuario SET estado = false WHERE id > 0 AND id ='" + id + "';";
                }
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
        */

        public void Insertar(Usuario t)// Se recibe el objeto de la clase a insertar
        {
            try
            {
                sql = "INSERT INTO usuario(nombre, nick, pass, id_nivel) VALUES ('" + t.nombre + "','" + t.nick + "','" + t.pass + "'," + t.id_nivel.id + ");";
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
       
        public List<Usuario> Listar(string query)
        {
            List<Usuario> usuarioLista = new List<Usuario>();
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
                                usuarioLista.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), new Nivel(reader.GetString(4) )));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return usuarioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return usuarioLista;
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