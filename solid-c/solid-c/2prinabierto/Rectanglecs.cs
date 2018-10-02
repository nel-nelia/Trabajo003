using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c._2prinabierto
{
    //se indican que nuestras figuras comparten propiedades y metodos
    public class Rectanglecs : IGeometricShape
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
