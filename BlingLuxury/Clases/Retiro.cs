using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Retiro
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public double cantidad { get; set; }
        public string razon { get; set; }
        public Usuario id_usuario { get; set; }

        public Retiro() //Constructor Vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Retiro(int id, DateTime fecha, double cantidad, 
            string razon, Usuario id_usuario)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.razon = razon;
            this.id_usuario = id_usuario;
        }
        public Retiro( DateTime fecha, double cantidad,
            string razon, Usuario id_usuario)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.razon = razon;
            this.id_usuario = id_usuario;
        }
    }
}
