using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Core
{
    public class Triangulo : IFigura
    {
        public double altura { get; set; }
        public double Base { get; set; }

        public double CalcularArea()
        {
            return (Base * altura) / 2;
        }

        public double CalcularPerimetro()
        {
            return 3 * Math.Sqrt(altura * altura + (Base / 2) * (Base / 2));
        }
    }
}
