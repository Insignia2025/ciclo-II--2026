using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas_mejorado
{
    class Circulo : Figura
    {
        private readonly double radio;

        public Circulo(double radio)
        {
              this.radio = radio;
        }

        public override double CalcularArea() => Math.PI * Math.Pow(radio, 2);
    }
}
