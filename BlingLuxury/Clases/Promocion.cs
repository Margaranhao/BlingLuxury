using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Promocion
    {
        public int id { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public bool oferta { get; set; }
        public Producto id_producto { get; set; }

        public Promocion() //Constructor Vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Promocion(int id, DateTime fechaInicio, 
            DateTime fechaFin, bool oferta, Producto id_producto)
        {
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.oferta = oferta;
            this.id_producto = id_producto;
        }
        //constructor con todos los parametros, menos el id, muy util para listar
        public Promocion(DateTime fechaInicio, DateTime fechaFin, 
            bool oferta, Producto id_producto)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.oferta = oferta;
            this.id_producto = id_producto;
        }
    }
}
