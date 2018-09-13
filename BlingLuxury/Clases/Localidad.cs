using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Localidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public CodigoPostal id_cp { get; set; }

        public Localidad()
        {

        }

        public Localidad(int id, string nombre, CodigoPostal id_cp)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_cp = id_cp;
        }
        public Localidad(string nombre, CodigoPostal id_cp)
        {
            this.nombre = nombre;
            this.id_cp= id_cp;
        }
    }
}
