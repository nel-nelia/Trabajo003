using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c.PrinResponUni
{
    public class PerimeterOperations
    {
        public double Sum(IEnumerable<Rectangle> rectangles)
        {
            double perimeter = 0;
            foreach (var rectangle in rectangles)
                perimeter += 2 * rectangle.Height + 2 * rectangle.Width;
            return perimeter;
        }
    }
}

