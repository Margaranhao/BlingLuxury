using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class EntidadFederativa
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private int id_municipio { get; set; }
        public EntidadFederativa()
        {

        }
        public EntidadFederativa(int id, string nombre, int id_municipio)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
        public EntidadFederativa(string nombre, int id_municipio)
        {
            this.nombre = nombre;
            this.id_municipio = id_municipio;
        }
    }
}
