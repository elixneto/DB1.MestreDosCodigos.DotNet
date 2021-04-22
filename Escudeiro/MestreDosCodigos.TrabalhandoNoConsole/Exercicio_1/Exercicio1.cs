using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            MostrarTexto();

            var A = ConsoleHelper.LerDouble("Informe um número A:");
            var B = ConsoleHelper.LerDouble("Informe um número B:");

            Somar(A, B);
            Subtrair(A, B);
            Dividir(A, B);
            Multiplicar(A, B);
            ImprimirAeB(A, B);
            Escolha();
        }

        private void Somar(double A, double B)
        {
            ConsoleHelper.Subtitulo("Some esses 2 valores");

            var calculadora = new CalculadoraSimples(A, B);
            var resultado = calculadora.Somar();

            ImprimirResultado(A, B, resultado, '+');

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "CalculadoraSimples", 16);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 14);
        }

        private void Subtrair(double A, double B)
        {
            ConsoleHelper.Subtitulo("Faça uma subtração do valor A - B");

            var calculadora = new CalculadoraSimples(A, B);
            var resultado = calculadora.Subtrair();

            ImprimirResultado(A, B, resultado, '-');

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "CalculadoraSimples", 17);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 15);
        }

        private void Dividir(double A, double B)
        {
            ConsoleHelper.Subtitulo("Divida o valor B por A");

            var calculadora = new CalculadoraSimples(A, B);
            var resultado = calculadora.Dividir();

            ImprimirResultado(A, B, resultado, '/');

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "CalculadoraSimples", 19);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 16);
        }

        private void Multiplicar(double A, double B)
        {
            ConsoleHelper.Subtitulo("Multiplique o valor A por B");

            var calculadora = new CalculadoraSimples(A, B);
            var resultado = calculadora.Multiplicar();

            ImprimirResultado(A, B, resultado, '*');

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "CalculadoraSimples", 18);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 17);
        }

        private void ImprimirAeB(double A, double B)
        {
            ConsoleHelper.Subtitulo("Imprima os valores de entrada, informando se o número é par ou ímpar");

            Console.WriteLine($"A = {A} ({ParOuImpar(A)})");
            Console.WriteLine($"B = {B} ({ParOuImpar(B)})");

            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 18);
        }

        private void Escolha()
        {
            ConsoleHelper.Subtitulo("Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada");

            var A = ConsoleHelper.LerDouble("Informe um número A:");
            var B = ConsoleHelper.LerDouble("Informe um número B:");

            var calculadora = new CalculadoraSimples(A, B);

            Console.WriteLine("Informe o símbolo da operação matemática (+, -, /, *)");
            var entradaDoUsuario = Console.ReadKey();
            var operacao = entradaDoUsuario.KeyChar;

            double resultado = operacao switch
            {
                '+' => calculadora.Somar(),
                '-' => calculadora.Subtrair(),
                '*' => calculadora.Multiplicar(),
                '/' => calculadora.Dividir(),
                _ => throw new Exception("Operação não reconhecida!")
            };

            ConsoleHelper.PressioneEnter();

            ImprimirResultado(A, B, resultado, operacao);

            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "Exercicio1", 19);
        }

        private void ImprimirResultado(double a, double b, double resultado, char operacao)
        {
            Console.WriteLine();

            if (operacao == '/')
            {
                Console.WriteLine($"{b} / {a} = {resultado}");
                return;
            }

            Console.WriteLine($"{a} {operacao} {b} = {resultado}");
        }

        string ParOuImpar(double numero) => (numero % 2) == 0 ? "par" : "ímpar";

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 1",
                "Crie uma aplicação que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados");

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1", "CalculadoraSimples");
            Console.WriteLine();
        }
    }
}
