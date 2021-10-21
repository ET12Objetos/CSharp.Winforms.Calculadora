using System;

namespace Calculadora.Core
{
    public class Cuadrado : IFigura
    {
        public double lado { get; set; }

        public double CalcularArea()
        {
            return lado * lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}
