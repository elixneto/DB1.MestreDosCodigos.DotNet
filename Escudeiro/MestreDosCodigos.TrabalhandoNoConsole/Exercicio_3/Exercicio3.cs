using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_3
{
    public class Exercicio3
    {
        public Exercicio3()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 3");

            var numero = 3;
            while (numero <= 99)
            {
                Console.WriteLine(numero);

                numero += 3;
            }
        }
    }
}
