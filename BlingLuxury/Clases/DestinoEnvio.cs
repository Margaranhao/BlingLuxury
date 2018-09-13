using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
   public class DestinoEnvio
    {
        public int id { get; set; }
        public double costo_economico { get; set; }
        public double costo_express { get; set; }
        public Localidad id_localidad { get; set; }
        public  TipoEnvio id_envio { get; set; }
        public DestinoEnvio()
        {

        }
        public DestinoEnvio(int id, double costo_economico, double costo_express,
            Localidad id_localidad, TipoEnvio id_envio)
        {
            this.id = id;
            this.costo_economico = costo_economico;
            this.costo_express = costo_express;
            this.id_localidad = id_localidad;
            this.id_envio = id_envio;
        }
        public DestinoEnvio(double costo_economico, double costo_express,
            Localidad id_localidad, TipoEnvio id_envio)
        {
            this.costo_economico = costo_economico;
            this.costo_express = costo_express;
            this.id_localidad = id_localidad;
            this.id_envio = id_envio;
        }
    }
}
