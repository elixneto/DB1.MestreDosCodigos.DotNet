using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Polimorfismo
{
    public static class TextoPolimorfismo
    {
        public static void Mostrar()
        {
            Console.Write("> As classes ");
            ConsoleHelper.Escrever("BeijaFlor", ConsoleColor.Green);
            Console.Write(" e ");
            ConsoleHelper.Escrever("Avestruz", ConsoleColor.Green);
            Console.Write(" herdam de ");
            ConsoleHelper.Escrever("Passaro", ConsoleColor.Yellow);
            Console.Write(" mas possui suas próprias implementações de métodos tendo a mesma assinatura");
            Console.WriteLine();
        }
    }
}
