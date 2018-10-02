using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c._2prinabierto
{
    //para este principio creamos una nueva clase esto araiz de que deseamos crear
    //una nueva figura o agregarle y modificamos los metodos para que afecten a las
    //areas y rectangulos 
    public class EquilateralTriangle : IGeometricShape
    {
        public double Sides { get; } = 3;
        public double SideLength { get; set; }
        

        public double Area()
        {
            return Math.Sqrt(3) * Math.Pow(SideLength, 2) / 4;
        }

        public double Perimeter()
        {
            return SideLength * 3;
        }
    }
}
