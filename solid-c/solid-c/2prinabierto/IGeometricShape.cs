using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_c._2prinabierto
{
    /*
     *se crea esta nueva interfaz a traves de la cual indicaremos que nuestra
     * figura comparte metodos como el area y el perimetro tambien se tendra que modificar 
     * las operaciones para que acepten este nuevo comportamiento 
     */
    public interface IGeometricShape
    {
         double Area();
        double Perimeter();
    }
}
