using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Deposito
    {
        private int id { get; set; }
        private double cantidad { get; set; }
        private DateTime fecha { get; set; }
        private int id_estado { get; set; }
        private int id_usuario { get; set; }
        public Deposito()
        {

        }
        public Deposito(int id, double cantidad, DateTime fecha, 
            int id_estado, int id_usuario)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id_estado = id_estado;
            this.id_usuario = id_usuario;
        }
        public Deposito(double cantidad, DateTime fecha, int id_estado, int id_usuario)
        {
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id_estado = id_estado;
            this.id_usuario = id_usuario;
        }
    }
}
