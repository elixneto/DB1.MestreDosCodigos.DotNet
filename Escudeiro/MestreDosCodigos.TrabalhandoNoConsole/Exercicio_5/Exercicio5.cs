using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_5
{
    public class Exercicio5
    {
        public Exercicio5()
        {
            MostrarTexto();

            double a = ConsoleHelper.LerDouble("Informe o valor de A:");
            double b = ConsoleHelper.LerDouble("Informe o valor de B:");
            double c = ConsoleHelper.LerDouble("Informe o valor de C:");

            var bhaskara = new Bhaskara(a, b, c);

            ConsoleHelper.Subtitulo("Imprima os resultados R1 e R2");

            Console.WriteLine($"R1 = {bhaskara.R1}");
            Console.WriteLine($"R2 = {bhaskara.R2}");

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_5", "Bhaskara", 30, 37);
        }

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 5",
                "Crie uma aplicação que calcule a fórmula de Bhaskara:",
                " - Recebea os valores a, b, c",
                " - Imprima os resultados R1 e R2",
                " - Use a biblioteca MATH");

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_5", "Bhaskara");
            Console.WriteLine();
        }
    }
}
