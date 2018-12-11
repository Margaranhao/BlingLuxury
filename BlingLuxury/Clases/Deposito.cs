using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Deposito
    {
        public int id { get; set; }
        public double cantidad { get; set; }
        public DateTime fecha { get; set; }
        public Estado id_estado { get; set; }//para saber si el deposito ha sido realizado, no realizado o cancelado
        public Usuario id_usuario { get; set; }
        //constructor por default
        public Deposito()
        {

        }

        //constructor con todos los parametros, muy util para listar
        public Deposito(int id, double cantidad, DateTime fecha, 
            Estado id_estado, Usuario id_usuario)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id_estado = id_estado;
            this.id_usuario = id_usuario;
        }

        //constructor sin id, muy util para inserts
        public Deposito(double cantidad, DateTime fecha, Estado id_estado, Usuario id_usuario)
        {
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id_estado = id_estado;
            this.id_usuario = id_usuario;
        }

        public Deposito(double cantidad, DateTime fecha, Estado id_estado)
        {
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.id_estado = id_estado;
        }
    }
}
