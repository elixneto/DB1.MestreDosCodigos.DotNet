using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_7
{
    public class Exercicio7
    {
        public Exercicio7()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 7",
                "Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares");

            Console.WriteLine();
            ConsoleHelper.PressioneEnter();

            var quantidadeDeNumeros = 4;

            var somaDosPares = 0;
            for (int i = 1; i <= quantidadeDeNumeros; i++)
            {
                var numero = ConsoleHelper.LerInteiro($"Informe o {(i)}º número:");

                if ((numero % 2) == 0)
                {
                    somaDosPares += numero;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"SOMA = {somaDosPares}");
        }
    }
}
