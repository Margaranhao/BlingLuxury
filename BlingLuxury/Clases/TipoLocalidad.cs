using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class TipoLocalidad
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private int id_localidad { get; set; }

        public TipoLocalidad()
        {

        }
        public TipoLocalidad(int id, string nombre, int id_licalidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
        public TipoLocalidad(string nombre, int id_localidad)
        {
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
    }
}
