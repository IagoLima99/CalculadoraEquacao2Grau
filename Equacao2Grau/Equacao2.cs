using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao2Grau
{
    public class Equacao2
    {
        private Double _delta;
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double? X1 { get; private set; }
        public double? X2 { get; private set; }
        public byte Solucao { get; private set; }




        public void Calcular()
        {
            CalcularDelta();
            if (this.Solucao != 0)
                CalcularResultado();
            else
            {
                this.X1 = null;
                this.X2 = null;
            }
        }


        // △ = b - 4.a.c

        private void CalcularDelta()
        {
            _delta = Math.Pow(this.B, 2) - 4 * this.A * this.C;

            if (_delta < 0)
                this.Solucao = 0;
            else if (_delta == 0)
                this.Solucao = 1;
            else
                this.Solucao = 2;
        }


        //      -b ± ✓Δ
        //  x = ________
        //         2a
        private void CalcularResultado()
        {
            var raizDelta = Math.Sqrt(_delta);

            this.X1 = (-this.B + raizDelta) / (2 * this.A);
            this.X2 = (-this.B - raizDelta) / (2 * this.A);

        }
    }
}
