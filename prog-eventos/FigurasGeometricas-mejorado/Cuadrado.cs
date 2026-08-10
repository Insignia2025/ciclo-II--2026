using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_mejorado
{
    class Cuadrado : Figura
    {
        private readonly double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea() => Math.Pow(lado, 2);
    }
}
