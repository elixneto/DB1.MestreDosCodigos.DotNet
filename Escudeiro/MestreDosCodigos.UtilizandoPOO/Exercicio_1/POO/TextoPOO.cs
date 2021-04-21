using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.POO
{
    public static class TextoPOO
    {
        public static void Mostrar()
        {
            Console.Write("> O objeto ");
            ConsoleHelper.Escrever($"{nameof(Carro)}", ConsoleColor.Green);
            Console.Write(" é uma classe");
            Console.WriteLine();
            Console.Write("> A variável ");
            ConsoleHelper.Escrever("carro", ConsoleColor.Blue);
            Console.Write(" é uma instância");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever($"{nameof(Carro.Ano)}", ConsoleColor.Cyan);
            Console.Write($" é uma propriedade da classe");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever($"{nameof(Carro.Buzinar)}", ConsoleColor.Yellow);
            Console.Write($"() é um método - comportamento - da classe");
            Console.WriteLine();
        }
    }
}
