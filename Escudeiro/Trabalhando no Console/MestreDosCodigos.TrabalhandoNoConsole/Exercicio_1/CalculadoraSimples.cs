using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1
{
    public class CalculadoraSimples
    {
        public double A { get; }
        public double B { get; }

        public CalculadoraSimples(double a, double b)
        {
            A = a;
            B = b;
        }

        public double Somar() => A + B;
        public double Subtrair() => A - B;
        public double Multiplicar() => A * B;
        public double Dividir()
        {
            if (A == 0)
            {
                throw new Exception($"Não é possível dividir {B} por 0 (zero)!");
            }

            return B / A;
        }
    }
}
