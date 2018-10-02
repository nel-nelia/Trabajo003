using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c
{
    class Program
    {
         // el programa principal se encarga de crear los rectangulos y de llamar a los
         //metodos para obtener las sumas, todo parece indicar que esta bien
         //pero estamos violando el principio de responsabilidad unica 
         // 
        static void Main(string[] args)
        {

            var rectangulos = new[]
            {
                new Rectangle {Width = 10, Height = 5},
                new Rectangle {Width = 4, Height = 6},
                new Rectangle {Width = 5, Height = 1},
                new Rectangle {Width = 8, Height = 9}
            };

            var sumaDeAreas = Rectangle.SumAreas(rectangulos);
            var sumaDePerimetros = Rectangle.SumPerimeters(rectangulos);

        }
    }
}
