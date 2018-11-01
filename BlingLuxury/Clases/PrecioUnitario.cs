using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class PrecioUnitario
    {
        public int id { get; set; }
        public double precio { get; set; }
        public PrecioAdquisicion id_precio_adquisicion { get; set; }

        public PrecioUnitario()//Constructor vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public PrecioUnitario(int id, double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.id = id;
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
        public PrecioUnitario(double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
    }
}
