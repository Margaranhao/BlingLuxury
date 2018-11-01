using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Rastreo
    {
        public int id { get; set; }
        public string ruta { get; set; }
        public Estado id_estado { get; set; }
        public Rastreo() //Constructor Vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Rastreo(int id, string ruta, Estado id_estado)
        {
            this.id = id;
            this.ruta = ruta;
            this.id_estado = id_estado;
        }
        public Rastreo(string tuta, Estado id_estado)
        {
            this.ruta = ruta;
            this.id_estado = id_estado;
        }
    }
}
