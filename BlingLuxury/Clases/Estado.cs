using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Estado
    {
        public int id { get; set; }
        public string nombre { get; set; }//Tipo de estado, realizado, no realiado, cancelado

        //constructor por default
        public Estado()
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Estado(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        //constructor sin id, muy util para insertspublic Estado(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
