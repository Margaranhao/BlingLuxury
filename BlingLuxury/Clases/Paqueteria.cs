using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Paqueteria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public TipoEnvio id_envio { get; set; }
        public Paqueteria() //Constructor vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public Paqueteria(int id, string nombre, TipoEnvio id_envio)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_envio = id_envio;
        }
        //Constructor sin el parametro id
        public Paqueteria(string nombre, TipoEnvio id_envio)
        {
            this.nombre = nombre;
            this.id_envio = id_envio;
        }
    }
}
