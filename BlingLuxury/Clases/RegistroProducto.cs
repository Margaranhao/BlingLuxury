using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    class RegistroProducto
    {
        //Las variables de tipo enteras que no requieran operaciones se deben considerar string
        //Tabla producto
       public int idProducto { get; set; }
       public int codigoProducto { get; set; }
       public double pesoProducto { get; set; }
       public int productoidModelo { get; set; }
       public int productoidPrecio_adquisicion { get; set; }
       public int productoidColor { get; set; }
       public int productoidCategoria { get; set; }
        //Tabla Modelo
       public int idModelo { get; set; }
       public string nombreModelo { get; set; }
       public int modeloidMarca { get; set; }
        //Tabla Precio Aquisición
       public int idPrecio_adquisicion { get; set; }
       public double precioPrecio_adqisicion { get; set; }
        //Tabla Color
       public int idColor { get; set; }
       public string nombreColor { get; set; }
        //Tabla Categoria
       public int idCategoria { get; set; }
       public string nombreCategoria { get; set; }
        //Tabla Marca
       public int idMarca { get; set; }
       public string nombreMarca { get; set; } 

       public RegistroProducto()
        {

        }
       public RegistroProducto(int idProducto, int codigoProducto, double pesoProducto, int productoidModelo, int productoidPrecio_adquisicion,
                               int productoidColor, int productoidCategoria, int idModelo, string nombreModelo, int modeloidMarca, int idPrecio_adquisicion,
                               double precioPrecio_adquisicion, int idColor, string nombreColor, int idCategoria, string nombreCategoria, int idMarca, string nombreMarca)
        {
            this.idProducto = idProducto;
            this.codigoProducto = codigoProducto;
            this.pesoProducto = pesoProducto;
            this.productoidModelo = productoidModelo;
            this.productoidPrecio_adquisicion = productoidPrecio_adquisicion;
            this.productoidColor = productoidColor;
            this.productoidCategoria = productoidCategoria;
            this.idModelo = idModelo;
            this.nombreModelo = nombreModelo;
            this.idPrecio_adquisicion = idPrecio_adquisicion;
            this.precioPrecio_adqisicion = precioPrecio_adqisicion;
            this.idColor = idColor;
            this.nombreColor = nombreColor;
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.idMarca = idMarca;
            this.nombreMarca = nombreMarca;
        }
    }
}
