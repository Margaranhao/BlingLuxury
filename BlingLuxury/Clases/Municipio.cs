using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BlingLuxury.Connection;
using BlingLuxury.DAO;

namespace BlingLuxury.Clases
{
    public class Municipio
    {
        public int id { get; set; }
        public string nombre { get; set; }//Nombre del Municipio
        public EntidadFederativa id_entidad_federativa { get; set; }

        //constructor por default
        public Municipio()
        {

        }
        public Municipio(int id)
        {
            this.id = id;
        }
        public Municipio(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            
        }

        //constructor con todos los parametros, muy util para listar
        public Municipio(int id, string nombre, EntidadFederativa id_entidad_federativa)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_entidad_federativa = id_entidad_federativa;
        }

        //constructor sin id, muy util para inserts
        public Municipio(string nombre, EntidadFederativa id_entidad_federativa)
        {
            this.nombre = nombre;
            this.id_entidad_federativa = id_entidad_federativa;
        }
        public Municipio(string nombre)
        {
            this.nombre = nombre;            
        }
    }
}