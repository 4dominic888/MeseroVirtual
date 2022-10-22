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

        public Alimento(string nombre, string imagen, string tipo, double precio)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Precio = precio;
        }

        public Alimento(){}


    }
}
