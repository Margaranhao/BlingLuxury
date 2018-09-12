using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Municipio
    {
        private int id { get; set; }
        private string nombre { get; set; }
        public int id_localidad { get; set; }
        public Municipio()
        {

        }
        public Municipio(int id, string nombre, int id_localidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
        public Municipio(string nombre, int id_localidad)
        {
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
    }
}
