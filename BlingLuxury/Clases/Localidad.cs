using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Localidad
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private int id_cp { get; set; }

        public Localidad()
        {

        }

        public Localidad(int id, string nombre, int id_cp)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_cp = id_cp;
        }
        public Localidad(string nombre, int id_cp)
        {
            this.nombre = nombre;
            this.id_cp= id_cp;
        }
    }
}
