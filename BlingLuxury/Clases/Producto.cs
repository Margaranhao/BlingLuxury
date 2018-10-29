﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.Clases
{
    public class Producto
    {
        public int id { get; set; }
        public string codigoDeBarras { get; set; }
        public double peso { get; set; }
        public Modelo id_modelo { get; set; }
        public PrecioAdquisicion id_precio_adquisicion { get; set; }
        public Color id_color { get; set; }
        public Categoria id_categoria { get; set; }

        public Producto()
        {

        }
        public Producto(int id)
        {
            this.id = id;
        }
        public Producto(int id, string codigoDeBarras, double peso,
            Modelo id_modelo, PrecioAdquisicion id_precio_adquisicion, Color id_color,
            Categoria id_categoria)
        {
            this.id = id;
            this.codigoDeBarras = codigoDeBarras;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }
        public Producto(string codigoDeBarras, double peso, Modelo id_modelo,
            PrecioAdquisicion id_precio_adquisicion, Color id_color, Categoria id_categoria)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;
        }

        public Producto(int id, string codigoBarras)
        {
            this.id = id;
            this.codigoDeBarras = codigoDeBarras;
        }
        public Producto(int id, double peso, Modelo id_modelo, PrecioAdquisicion id_precio_adquisicion, Color id_color, Categoria id_categoria)
        {
            this.id = id;
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;

        }
        public Producto(double peso, Modelo id_modelo, PrecioAdquisicion id_precio_adquisicion, Color id_color, Categoria id_categoria)
        {
            this.peso = peso;
            this.id_modelo = id_modelo;
            this.id_precio_adquisicion = id_precio_adquisicion;
            this.id_color = id_color;
            this.id_categoria = id_categoria;

        }
    }
}

