using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c
{
    //clase creada rectangulo 
    public class Rectangle 
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }

        //la violancion ocurre al moemnto de declarar los metodos SumAreas y SumPerimeters
        //dentro de la misma clase Rectangle, esque apesar de estar relacionados como tal
        //la sumatoria forma parte de nuestra logica de la aplicacion y no de la logica 
        //de que podria tener un rectangulo 

            //para cumplir con este principio tenemos que crear la logica de la clase rectangle
            //entonces introducimos un par de clases encargadas de utilizar las operaciones
            // sobre los conjuntos de rectangulos 
        public static double SumAreas(IEnumerable<Rectangle> rectangles)
        {
            //   
            double area = 0;
            foreach (var rectangle in rectangles)
                area += rectangle.Height * rectangle.Width;
            return area;

            //para el segundo principio, agregamos el metodo 
           /* double area = 0;
            foreach (var shape in shapes)
                if (shape is Rectangle)
                    area += ((Rectangle)shape).Height *
                        ((Rectangle)shape).Width;
                else if (shape is EquilateralTriangle)
                    area += Math.Sqrt(3) *
                    Math.Pow(((EquilateralTriangle)shape).SideLength, 2) / 4;
            return area;
            */
        }

        public static double SumPerimeters(IEnumerable<Rectangle> rectangles)
        {
            //
            double perimeter = 0;
            foreach (var rectangle in rectangles)
                perimeter += 2 * rectangle.Height + 2 * rectangle.Width;
            return perimeter;

            /* para el segundo principio se verifica a que metodo y se realiza el 
             * calculo apropiado, pero se esta violando el principio para la solucion
             * de este es crear una interfaz 
             double perimeter = 0;
            foreach (var shape in shapes)
	            if (shape is Rectangle)                
	            perimeter +=  2 * ((Rectangle)shape).Height + 2 * 
		        ((Rectangle) shape).Width;
	            else if (shape is EquilateralTriangle)
	            perimeter +=((EquilateralTriangle) shape).SideLength *3;
             return perimeter;
            */

        }

    }
}
