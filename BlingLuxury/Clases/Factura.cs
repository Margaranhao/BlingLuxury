using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Factura
    {
        public int id { get; set; }
        public int folio { get; set; }
        public DateTime fecha { get; set; }
        public double total { get; set; }
        public Cliente id_cliente { get; set; }
        public DestinoEnvio id_destino { get; set; }
        public Usuario id_usuario { get; set; }
        public Factura()
        {

        }
        public Factura(int id, int folio, DateTime fecha, 
            double total, Cliente id_cliente, DestinoEnvio id_destino, Usuario id_usuario)
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
            Cliente id_cliente, DestinoEnvio id_destino, Usuario id_usuario)
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
