using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class CodigoPostal
    {
        //variables
        public int id { get; set; }
        public string nombre { get; set; } //Codigo Postal de 5 digitos 

        //constructor por default
        public CodigoPostal()
        {

        }
        //Constructor con todos los parametros
        public CodigoPostal(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        //constructor sin id util para los insert
        public CodigoPostal(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
