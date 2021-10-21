using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Core
{
    public class Circunferencia : IFigura
    {
        public double radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }
    }
}
