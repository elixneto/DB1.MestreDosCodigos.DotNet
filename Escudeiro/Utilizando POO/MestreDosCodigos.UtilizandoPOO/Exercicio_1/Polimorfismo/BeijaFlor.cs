using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Polimorfismo
{
    class BeijaFlor : Passaro
    {
        public void BaterAsas()
        {
            Console.Write("(");
            ConsoleHelper.Escrever($"{this.GetType().Name}", ConsoleColor.Green);
            Console.Write(")");
            ConsoleHelper.Escrever($"{nameof(Passaro)}", ConsoleColor.Yellow);
            Console.Write(".");
            ConsoleHelper.Escrever("BaterAsas", ConsoleColor.Yellow);
            Console.Write("(): bater as asas 75 vezes por segundo");
            ConsoleHelper.Escrever("'", ConsoleColor.Blue);
            Console.Write("(");
            Console.WriteLine();
        }
    }
}
