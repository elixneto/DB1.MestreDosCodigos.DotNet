using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1
{
    public class CalculadoraSimples
    {
        public int A { get; }
        public int B { get; }

        public CalculadoraSimples(int a, int b)
        {
            A = a;
            B = b;
        }

        public int Somar() => A + B;
        public int Subtrair() => A - B;
        public int Multiplicar() => A * B;
        public int Dividir()
        {
            if (A == 0)
            {
                throw new Exception($"Não é possível dividir {B} por 0 (zero)!");
            }

            return B / A;
        }
    }
}
