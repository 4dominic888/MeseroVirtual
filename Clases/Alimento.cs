using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alimento
    {
        public string? Nombre { get; set; }
        public string? Imagen { get; set; }
        public string? Tipo { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; } = 0;

        public Alimento(string nombre, string imagen, string tipo, double precio)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Precio = precio;
        }
        public Alimento(){}

        public override string ToString()
        {
            //{Nombre}♦{Imagen}♦{Tipo}♦{Precio}
            return $"{this.Nombre}♦{this.Imagen}♦{this.Tipo}♦{this.Precio}";
        }

        public string imprimirBoleta()
        {
            string texto = $"{this.Nombre} x{this.Cantidad}";
            return $"{texto.PadRight(80)}S/. {this.Precio*this.Cantidad}";
        }
    }
}
