using MestreDosCodigos.TrabalhandoNoConsole;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.Polimorfismo;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Abstracao
{
    public static class TextoAbstracao
    {
        public static void Mostrar()
        {
            Console.Write("> O objeto ");
            ConsoleHelper.Escrever("Passaro", ConsoleColor.Yellow);
            Console.Write(" é uma Interface e não pode ser instanciada");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever($"{nameof(BeijaFlor)}", ConsoleColor.Green);
            Console.Write(" e ");
            ConsoleHelper.Escrever($"{nameof(Avestruz)}", ConsoleColor.Green);
            Console.Write(" são classes derivadas de ");
            ConsoleHelper.Escrever("Passaro", ConsoleColor.Yellow);
            Console.Write(" e podem ser instanciadas");
            Console.WriteLine();
        }
    }
}
