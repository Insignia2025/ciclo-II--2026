using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_mejorado
{
    class Rectangulo : Figura
    {
        private readonly double ancho;
        private readonly double altura;

        public Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        public override double CalcularArea() => ancho * altura;
    }
}
