using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_7
{
    public class Exercicio7
    {
        public Exercicio7()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 7");

            var quantidadeDeNumeros = 4;

            Console.WriteLine($"Informe {quantidadeDeNumeros} inteiros:");

            var somaDosPares = 0;
            for (int i = 1; i <= quantidadeDeNumeros; i++)
            {
                var numero = ConsoleHelper.LerInteiro();

                if((numero %2) == 0)
                {
                    somaDosPares += numero;
                }
            }

            Console.WriteLine($"SOMA = {somaDosPares}");
        }
    }
}
