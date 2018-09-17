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
        public string nombre { get; set; }//Nombre de la comunidad, ciudad, pueblo, etc.
        public CodigoPostal id_cp { get; set; }

        //constructor por default
        public Localidad()
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Localidad(int id, string nombre, CodigoPostal id_cp)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_cp = id_cp;
        }
        //constructor sin id, muy util para inserts
        public Localidad(string nombre, CodigoPostal id_cp)
        {
            this.nombre = nombre;
            this.id_cp= id_cp;
        }
    }
}
