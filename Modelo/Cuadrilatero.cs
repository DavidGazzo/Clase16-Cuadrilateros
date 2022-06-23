using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_Cuadrilateros.Modelo
{
    public abstract class Cuadrilateros
    {
        private int[] _coordInfIzq;
        private int[] _coordSupIzq;
        private int[] _coordSupDer;
        private int[] _coordInfDer;

        public int[] CoordInfIzq
        {
            get => _coordInfIzq;
            set => _coordInfIzq = value;
        }
        public int[] CoordSupIzq
        {
            get => _coordSupIzq;
            set => _coordSupIzq = value;            
        }
        public int[] CoordSupDer
        {
            get => _coordSupDer;
            set => _coordSupDer = value;
        }

        public int[] CoordInfDer
        {
            get => _coordInfDer;
            set => _coordInfDer = value;
        }

        public Cuadrilateros(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer)
        {
            CoordInfIzq = infIzq;
            CoordSupIzq = supIzq;
            CoordInfDer = infDer;
            CoordSupDer = supDer;
        }

        public abstract double Area(int[] infIzq, int[] supIzq, int[] infDer, int[] supDer); //: base(infIzq, supIzq, infDer, supDer);        

    }
}
