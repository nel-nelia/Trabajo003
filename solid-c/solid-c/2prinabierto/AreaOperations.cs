using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c.PrinResponUni
{
    public class AreaOperationss
    {
        //introducir un par de clases encargadas de realizar las operaciones en conjunto
        //de rectangulos y su codigo es si cada clase solo tiene una responsabilidad 
        //una representa un rectangulo y las otras se encargan de realizar las operaciones
        public double Sum(IEnumerable<Rectangle> rectangles)
        {
            double area = 0;
            foreach (var rectangle in rectangles)
                area += rectangle.Height * rectangle.Width;
            return area;
        }
    }
}
}
