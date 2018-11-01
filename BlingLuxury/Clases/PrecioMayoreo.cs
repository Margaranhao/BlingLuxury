using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class PrecioMayoreo
    {
        public int id { get; set; }
        public double precio { get; set; }
        public PrecioAdquisicion id_precio_adquisicion { get; set; }

        public PrecioMayoreo() //Constructor Vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public PrecioMayoreo(int id, double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.id = id;
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
        //constructor con todos los parametros, menos el id muy util para listar
        public PrecioMayoreo(double precio, PrecioAdquisicion id_precio_adquisicion)
        {
            this.precio = precio;
            this.id_precio_adquisicion = id_precio_adquisicion;
        }
    }
}
