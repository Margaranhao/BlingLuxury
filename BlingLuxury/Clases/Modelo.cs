using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Modelo
    {
        public int id { get; set; }
        public string nombre { get; set; }//nombre del modelo
        public Marca id_marca { get; set; }
        //constructor por default
        public Modelo()
        {

        }
        public Modelo(int id)
        {
            this.id = id;
        }
        public Modelo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }
        //constructor con todos los parametros, muy util para listar
        public Modelo(int id, string nombre, Marca id_marca)
        {
            this.id = id;
            this.nombre = nombre;
            this.id_marca = id_marca;
        }

        //constructor sin id, muy util para inserts
        public Modelo(string nombre, Marca id_marca)
        {
            this.nombre = nombre;
            this.id_marca = id_marca;
        }
    }
}
