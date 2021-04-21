using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Polimorfismo
{
    class BeijaFlor : Passaro
    {
        public void BaterAsas()
        {
            ConsoleHelper.Escrever($"{this.GetType().Name}", ConsoleColor.Green);
            Console.Write(".");
            ConsoleHelper.Escrever("BaterAsas", ConsoleColor.Yellow);
            Console.Write("(): bater as asas 75 vezes por segundo");
            Console.WriteLine();
        }
    }
}
