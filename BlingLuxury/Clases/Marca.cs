using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }//nombre de la marca

        //constructor por default
        public Marca()
        {

        }
        public Marca(int id)
        {
            this.id = id;
        }
        //constructor con todos los parametros, muy util para listar
        public Marca(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        //constructor sin id, muy util para inserts
        public Marca(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
