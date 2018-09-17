using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Municipio
    {
        public int id { get; set; }
        public string nombre { get; set; }//Nombre del Municipio
        public Localidad id_localidad { get; set; }

        //constructor por default
        public Municipio()
        {

        }

        //constructor con todos los parametros, muy util para listar
        public Municipio(int id, string nombre, Localidad id_localidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }

        //constructor sin id, muy util para inserts
        public Municipio(string nombre, Localidad id_localidad)
        {
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
    }
}
