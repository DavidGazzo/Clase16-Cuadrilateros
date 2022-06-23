using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_Cuadrilateros.Modelo
{
    public class Trapecio : Cuadrilateros
    {
        public Trapecio(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer) : base(infIzq, supIzq, infDer, supDer)
        {        
        }
            
        public override double Area(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer)
        {
            int valor1 = infIzq[0] * infDer[1];
            int valor2 = infDer[0] * supDer[1];
            int valor3 = supDer[0] * supIzq[1];
            int valor4 = supIzq[0] * infIzq[1];
            int sumaNum = valor1 + valor2 + valor3 + valor4;

            int valorA = infIzq[1] * infDer[0];
            int valorB = infDer[1] * supDer[0];
            int ValorC = supDer[1] * supIzq[0];
            int valorD = supIzq[1] * infIzq[0];
            int sumaLetras = valorA + valorB + ValorC + valorD;

            double superficie = 0.5 * (sumaNum - sumaLetras);

            return superficie;
        }

    }
}
