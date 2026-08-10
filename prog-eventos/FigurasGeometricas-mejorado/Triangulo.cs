using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_mejorado
{
    class Triangulo : Figura
    {
        private readonly double baseT;
        private readonly double altura;

        public Triangulo(double baseT, double altura)
        {
            this.baseT = baseT;
            this.altura = altura;
        }

        public override double CalcularArea() => (baseT * altura) / 2;
    }
}
