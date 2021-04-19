using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_5
{
    public class Exercicio5
    {
        public Exercicio5()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 5");

            double a = ConsoleHelper.LerDouble("Informe o valor de A:");
            double b = ConsoleHelper.LerDouble("Informe o valor de B:");
            double c = ConsoleHelper.LerDouble("Informe o valor de C:");

            var bhaskara = new Bhaskara(a, b, c);

            Console.WriteLine($"R1 = {bhaskara.R1}");
            Console.WriteLine($"R2 = {bhaskara.R2}");
        }
    }
}
