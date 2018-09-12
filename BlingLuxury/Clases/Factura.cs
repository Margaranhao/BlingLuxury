using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Factura
    {
        private int id { get; set; }
        private int folio { get; set; }
        private DateTime fecha { get; set; }
        private double total { get; set; }
        private int id_cliente { get; set; }
        private int id_destino { get; set; }
        private int id_usuario { get; set; }
        public Factura()
        {

        }
        public Factura(int id, int folio, DateTime fecha, 
            double total, int id_cliente, int id_destino, int id_usuario)
        {
            this.id = id;
            this.folio = folio;
            this.fecha = fecha;
            this.total = total;
            this.id_cliente = id_cliente;
            this.id_destino = id_destino;
            this.id_usuario = id_usuario;
        }
        public Factura(int folio, DateTime fecha, double total,
            int id_cliente, int id_destino, int id_usuario)
        {
            this.folio = folio;
            this.fecha = fecha;
            this.total = total;
            this.id_cliente = id_cliente;
            this.id_destino = id_destino;
            this.id_usuario = id_usuario;
        }
        
    }
}
