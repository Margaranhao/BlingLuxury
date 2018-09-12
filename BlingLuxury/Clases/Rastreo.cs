using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class Rastreo
    {
        private int id { get; set; }
        private string ruta { get; set; }
        private int id_estado { get; set; }
        public Rastreo()
        {

        }
        public Rastreo(int id, string ruta, int id_estado)
        {
            this.id = id;
            this.ruta = ruta;
            this.id_estado = id_estado;
        }
        public Rastreo(string tuta, int id_estado)
        {
            this.ruta = ruta;
            this.id_estado = id_estado;
        }
    }
}
