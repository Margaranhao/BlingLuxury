using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Retiro
    {
        private int id { get; set; }
        private DateTime fecha { get; set; }
        public double cantidad { get; set; }
        private string razon { get; set; }
        private int id_usuario { get; set; }

        public Retiro()
        {

        }
        public Retiro(int id, DateTime fecha, double cantidad, 
            string razon, int id_usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.razon = razon;
            this.id_usuario = id_usuario;
        }
        public Retiro( DateTime fecha, double cantidad,
            string razon, int id_usuario)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.razon = razon;
            this.id_usuario = id_usuario;
        }
    }
}
