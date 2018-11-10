using BlingLuxury.CRUD;
using BlingLuxury.Connection;
using BlingLuxury.Clases;
using MySql.Data.MySqlClient;
using BlingLuxury.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.DAO
{
    public class RegistroUsuarioDAO:CRUD<RegistroUsuario>
    {
        private static RegistroUsuarioDAO registroUsuarioDAO;
        protected string sql;
        public RegistroUsuarioDAO()
        {

        }
        public static RegistroUsuarioDAO getInstance()//evita que la clase se instancie mas de una ves
        {
            if (registroUsuarioDAO == null)
                registroUsuarioDAO = new RegistroUsuarioDAO();
            return registroUsuarioDAO;
        }

        public void Actualizar(RegistroUsuario t, int id)
        {
            throw new NotImplementedException();
        }

        public RegistroUsuario Buscar(string query)
        {
            throw new NotImplementedException();
        }

        public void CambiarEstado(int id, RegistroUsuario t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(RegistroUsuario t)
        {
            throw new NotImplementedException();
        }

        public List<RegistroUsuario> Listar(string query)
        {
            List<RegistroUsuario> registroUsuarioLista = new List<RegistroUsuario>();
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
                                int idUsuario = reader.GetInt32(0);
                                string nombreUsuario = reader.GetString(1);
                                string nickUsuario = reader.GetString(2);
                                string pass = reader.GetString(3);
                                Nivel nivel = new Clases.Nivel(reader.GetInt32(4), reader.GetString(5));
                                Rango rango = new Clases.Rango(reader.GetInt32(6), reader.GetString(7));
                                int idCliente = reader.GetInt32(8);
                                string telefonoCliente = reader.GetString(9);
                                string calleCliente = reader.GetString(10);
                                Localidad localidad = new Localidad(reader.GetInt32(11), reader.GetString(12));
                                CodigoPostal codigoPostal = new CodigoPostal(reader.GetInt32(13), reader.GetString(14));
                                Municipio municipio = new Municipio(reader.GetInt32(15), reader.GetString(16));
                                EntidadFederativa entidadFederativa = new EntidadFederativa(reader.GetInt32(17),reader.GetString(18));

                                registroUsuarioLista.Add(new RegistroUsuario(idUsuario, nombreUsuario, nickUsuario, pass, nivel, rango, idCliente,
                                    telefonoCliente, calleCliente, localidad,codigoPostal, municipio, entidadFederativa));
                                
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroUsuarioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return registroUsuarioLista;
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
