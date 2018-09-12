using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Promocion
    {
        private int id { get; set; }
        private DateTime fechaInicio { get; set; }
        private DateTime fechaFin { get; set; }
        private bool oferta { get; set; }
        private int id_producto { get; set; }

        public Promocion()
        {

        }
        public Promocion(int id, DateTime fechaInicio, 
            DateTime fechaFin, bool oferta, int id_producto)
        {
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.oferta = oferta;
            this.id_producto = id_producto;
        }
        public Promocion(DateTime fechaInicio, DateTime fechaFin, 
            bool oferta, int id_producto)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.oferta = oferta;
            this.id_producto = id_producto;
        }
    }
}
