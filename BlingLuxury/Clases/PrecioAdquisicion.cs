using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class PrecioAdquisicion
    {
        public int id { get; set; }
        public double precio { get; set; }
        public PrecioAdquisicion() //Constructor Vacio
        {

        }
        public PrecioAdquisicion(int id, double precio)  //constructor con todos los parametros, muy util para listar
        {
            this.id = id;
            this.precio = precio;
        }
        public PrecioAdquisicion(double precio) //Constructor con el parametro de precio
        {
            this.precio = precio;
        }
    }
}
