using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BlingLuxury.Clases
{
    public class Localidad
    {
        public int id { get; set; }
        public string nombre { get; set; }//Nombre de la comunidad, ciudad, pueblo, etc.
        public Municipio id_municipio { get; set; }
        public TipoLocalidad id_tipo_localidad { get; set; }
        public CodigoPostal id_cp { get; set; }

        //constructor por default
        public Localidad()
        {

        }

        public Localidad(int id)
        {
            this.id = id;
        }
        public Localidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //constructor con todos los parametros, muy util para listar
        public Localidad(int id, string nombre, Municipio id_municipio, TipoLocalidad id_tipo_localidad, CodigoPostal id_cp)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_municipio = id_municipio;
            this.id_tipo_localidad = id_tipo_localidad;
            this.id_cp = id_cp;
        }
        //constructor sin id, muy util para inserts
        public Localidad(string nombre, CodigoPostal id_cp)
        {
            this.nombre = nombre;
            this.id_municipio = id_municipio;
            this.id_tipo_localidad = id_tipo_localidad;
            this.id_cp = id_cp;
        }
    }
}
