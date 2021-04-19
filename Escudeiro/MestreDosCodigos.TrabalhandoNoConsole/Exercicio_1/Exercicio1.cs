using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 1");

            int A = ConsoleHelper.LerInteiro("Informe um inteiro:");
            int B = ConsoleHelper.LerInteiro("Informe um inteiro:");

            var calculadora = new CalculadoraSimples(A, B);

            Console.WriteLine("Informe o símbolo da operação matemática (+, -, /, *)");
            var entradaDoUsuario = Console.ReadKey();
            var operacao = entradaDoUsuario.KeyChar;

            int resultado = operacao switch
            {
                '+' => calculadora.Somar(),
                '-' => calculadora.Subtrair(),
                '*' => calculadora.Multiplicar(),
                '/' => calculadora.Dividir(),
                _ => throw new Exception("Operação não reconhecida!")
            };

            ImprimirResultado(A, B, resultado, operacao);
        }

        void ImprimirResultado(int a, int b, int resultado, char operacao)
        {
            Console.WriteLine();

            if (operacao == '/')
            {
                Console.WriteLine($"{b} ({ParOuImpar(b)}) / {a} ({ParOuImpar(a)}) = {resultado}");
                return;
            }

            Console.WriteLine($"{a} ({ParOuImpar(a)}) {operacao} {b} ({ParOuImpar(b)}) = {resultado}");
        }

        string ParOuImpar(int numero) => (numero % 2) == 0 ? "par" : "ímpar";
    }
}
