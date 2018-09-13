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
        public string nombre { get; set; }
        public Localidad id_localidad { get; set; }
        public Municipio()
        {

        }
        public Municipio(int id, string nombre, Localidad id_localidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
        public Municipio(string nombre, Localidad id_localidad)
        {
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
    }
}
