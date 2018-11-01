using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class TipoLocalidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Localidad id_localidad { get; set; }

        public TipoLocalidad() //Constructor Vaciio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public TipoLocalidad(int id, string nombre, Localidad id_licalidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
        public TipoLocalidad(string nombre, Localidad id_localidad)
        {
            this.nombre = nombre;
            this.id_localidad = id_localidad;
        }
    }
}
