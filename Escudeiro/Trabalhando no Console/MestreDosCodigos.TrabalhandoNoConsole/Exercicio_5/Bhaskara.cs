using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_5
{
    public class Bhaskara
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Delta { get; private set; }
        public double R1 { get; private set; }
        public double R2 { get; private set; }

        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            CalcularDelta();
            CalcularR1();
            CalcularR2();
        }
        
        void CalcularDelta()
        {
            Delta = Math.Pow(B, 2) - (4 * A * C);
        }

        void CalcularR1()
        {
            var raizDelta = Math.Sqrt(Delta);

            R1 = ((B * -1) + raizDelta) / (2 * A);
        }

        void CalcularR2()
        {
            var raizDelta = Math.Sqrt(Delta);

            R2 = ((B * -1) - raizDelta) / (2 * A);
        }
    }
}
