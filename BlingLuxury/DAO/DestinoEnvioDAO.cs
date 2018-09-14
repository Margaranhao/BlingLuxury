﻿using BlingLuxury.Clases;
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
    public class DestinoEnvioDAO : CRUD<DestinoEnvio>
    {
        private static DestinoEnvioDAO destinoenvioDAO;
        protected string sql;

        public DestinoEnvioDAO()
        {

        }

        public static DestinoEnvioDAO getInstance()
        {
            if (destinoenvioDAO == null)
                destinoenvioDAO = new DestinoEnvioDAO();
            return destinoenvioDAO;
        }
        public void Actualizar(int id, DestinoEnvio t)
        {
            try
            {
                sql = "UPDATE destino_envio SET id_envio = '" + t.id_envio + "' WHERE id > 0 AND id = '" + id + "';";
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

        public DestinoEnvio Buscar(string query)
        {
            try
            {
                Conexion.getInstance().setCadenaConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Conexion.getInstance().getConnection()))
                {
                    //Se crea la clase del objeto a buscar y el DataReader que tomara la respuesta de la consulta
                    MySqlDataReader reader;
                    DestinoEnvio destinoenvio;
                    cmd.Prepare();
                    cmd.CommandTimeout = 60;
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)//Se comprueba que el reader tenga resultado
                        {
                            while (reader.Read())//Se recorre cada elemento que obtuvo el reader
                            {
                                //Se crea un nuevo objeto de la clase y se retorna
                                destinoenvio = new DestinoEnvio();// reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), new Localidad(reader.GetString(3), new CodigoPostal(reader.GetString(4), new TipoLocalidad(reader.GetString(5), new TipoEnvio(reader.GetString(6), reader.GetDateTime(7))))));
                                return destinoenvio;
                            }
                            //Se Cierra la conexión y se retorna
                            Conexion.getInstance().getConnection().Close();
                            return new DestinoEnvio();
                        }
                        else
                        {
                            //Se cierra la conexión y se retorna una objeto de la clase vacio
                            Conexion.getInstance().getConnection().Close();
                            return new DestinoEnvio();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstado(int id, DestinoEnvio t)
        {
            throw new NotImplementedException();
        }

        public void Insertar(DestinoEnvio t)
        {
            try
            {
                sql = "INSERT INTO destino_envio(costo_economico, costo_express, id_localidad, id_envio)VALUES('" + t.costo_economico + "','" + t.costo_express + "','" + t.id_localidad + "','" + t.id_envio + "');";
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

        public List<DestinoEnvio> Listar(string query)
        {
            List<DestinoEnvio> destinoenvioLista = new List<DestinoEnvio>();
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
                                destinoenvioLista.Add(new DestinoEnvio()); // reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), new Localidad(reader.GetString(3), new CodigoPostal(reader.GetString(4), new TipoLocalidad(reader.GetString(5), new TipoEnvio(reader.GetString(6), reader.GetDateTime(7))))));
                            }
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return destinoenvioLista;
                        }
                        else
                        {
                            Conexion.getInstance().Desconectar();
                            reader.Close();
                            return destinoenvioLista;
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