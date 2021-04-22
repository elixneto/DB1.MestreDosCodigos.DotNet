using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_3
{
    public class Exercicio3
    {
        public Exercicio3()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 3",
                "Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while");

            ConsoleHelper.PressioneEnter();

            var numero = 1;
            while (numero <= 100)
            {
                if((numero%3) == 0)
                {
                    Console.WriteLine(numero);
                }

                numero++;
            }

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_3", "Exercicio3", 15);
        }
    }
}
