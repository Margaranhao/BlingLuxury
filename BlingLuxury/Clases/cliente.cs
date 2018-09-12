using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.CLASES
{
   public class Cliente
    {
        //Las variables de tipo enteras que no requieran operaciones se deben considerar string
        private int id { set; get; }
        private string telefono { set; get; }
        private string calle { set; get; }
        private string colonia { set; get; }
        private string id_rango { set; get; }
        private string id_municipio { set; get; }
        private string id_usuario { set; get; }
        public Cliente()//Toda clase debe tener un constructor vacio
        {

        }
        public Cliente(int id, string telefono, string calle, string colonia, string rango, string id_municipio, string id_usuario)//Constructor con todos los valores es muy util para listar
        {
            this.id = id;
            this.telefono = telefono;
            this.calle = calle;
            this.colonia = colonia;
            this.id_rango = id_rango;
            this.id_municipio = id_municipio;
            this.id_usuario = id_usuario;
        }
        public Cliente(string nombre, string nick, string pass, int id_nivel)//Constructor sin id es muy util cuando no se necesita el id como en los insert
        {
            this.telefono = telefono;
            this.calle = calle;
            this.colonia = colonia;
            this.id_rango = id_rango;
            this.id_municipio = id_municipio;
            this.id_usuario = id_usuario;
        }
    }
}
