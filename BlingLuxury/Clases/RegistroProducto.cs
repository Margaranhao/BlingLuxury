using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class RegistroProducto
    {
        //Las variables de tipo enteras que no requieran operaciones se deben considerar string
        //Tabla producto
        public int idProducto { get; set; }
        public string codigoProducto { get; set; }
        public double pesoProducto { get; set; }
        public Modelo productoIdModelo { get; set; }
        public Marca modeloIdMarca { get; set; }
        public PrecioAdquisicion productoIdPrecio_adquisicion { get; set; }
        public Color productoIdColor { get; set; }
        public Categoria productoIdCategoria { get; set; }


        public RegistroProducto() //Constructor Vacio
        {

        }
        //constructor con todos los parametros, muy util para listar
        public RegistroProducto(int idProducto, string codigoProducto, double pesoProducto, Modelo productoIdModelo, Marca modeloIdMarca,
                                PrecioAdquisicion productoIdPrecio_adquisicion, Color productoIdColor, Categoria productoIdCategoria)
        {
            this.idProducto = idProducto;
            this.codigoProducto = codigoProducto;
            this.pesoProducto = pesoProducto;
            this.productoIdModelo = productoIdModelo;
            this.modeloIdMarca = modeloIdMarca;
            this.productoIdPrecio_adquisicion = productoIdPrecio_adquisicion;
            this.productoIdColor = productoIdColor;
            this.productoIdCategoria = productoIdCategoria;

        }
    }
}
