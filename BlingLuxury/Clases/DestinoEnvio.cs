using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class DestinoEnvio
    {
        private int id { get; set; }
        private double costo_economico { get; set; }
        private double costo_express { get; set; }
        private int id_localidad { get; set; }
        private int id_envio { get; set; }
        public DestinoEnvio()
        {

        }
        public DestinoEnvio(int id, double costo_economico, double costo_express,
            int id_localidad, int id_envio)
        {
            this.id = id;
            this.costo_economico = costo_economico;
            this.costo_express = costo_express;
            this.id_localidad = id_localidad;
            this.id_envio = id_envio;
        }
        public DestinoEnvio(double costo_economico, double costo_express,
            int id_localidad, int id_envio)
        {
            this.costo_economico = costo_economico;
            this.costo_express = costo_express;
            this.id_localidad = id_localidad;
            this.id_envio = id_envio;
        }
    }
}
