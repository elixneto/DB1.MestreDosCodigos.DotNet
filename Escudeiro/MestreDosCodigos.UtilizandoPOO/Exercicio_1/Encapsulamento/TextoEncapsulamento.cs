using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Encapsulamento
{
    public static class TextoEncapsulamento
    {
        public static void Mostrar()
        {
            Console.Write("> A classe ");
            ConsoleHelper.Escrever("Aviao", ConsoleColor.Green);
            Console.Write(" possui a palavra-chave ");
            ConsoleHelper.Escrever("sealed", ConsoleColor.Blue);
            Console.Write(" que a torna inacessível para ser uma classe base de herança");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("private readonly", ConsoleColor.Blue);
            Console.Write(" faz com que ");
            ConsoleHelper.Escrever("LinhaAerea", ConsoleColor.Cyan);
            Console.Write(" esteja disponível somente dentro do contexto da classe e a única forma de atribuir valor é no construtor ou na declaração do campo");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("private", ConsoleColor.Blue);
            Console.Write(" ");
            ConsoleHelper.Escrever("AcentosOcupados", ConsoleColor.Cyan);
            Console.Write(" está disponível somente dentro do contexto da classe, porém podemos atribuir valores (diferente do ");
            ConsoleHelper.Escrever("readonly", ConsoleColor.Blue);
            Console.Write(")");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("public string ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Piloto", ConsoleColor.Cyan);
            Console.Write(" { ");
            ConsoleHelper.Escrever("get", ConsoleColor.Blue);
            Console.Write("; } está disponível para leitura fora do contexto da classe, porém não é possível atribuir valores nem mesmo dentro da própria classe (a não ser em seu construtor)");
            Console.WriteLine();
            Console.Write("Tem o mesmo efeito de ser ");
            ConsoleHelper.Escrever("public readonly string ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Piloto", ConsoleColor.Cyan);
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("public string ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Copiloto", ConsoleColor.Cyan);
            Console.Write(" { ");
            ConsoleHelper.Escrever("get", ConsoleColor.Blue);
            Console.Write("; ");
            ConsoleHelper.Escrever("private set", ConsoleColor.Blue);
            Console.Write("; } está disponível para leitura fora do contexto da classe e é possível atribuir valores dentro da classe");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("public string ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Cor", ConsoleColor.Cyan);
            Console.Write(" { ");
            ConsoleHelper.Escrever("get", ConsoleColor.Blue);
            Console.Write("; ");
            ConsoleHelper.Escrever("set", ConsoleColor.Blue);
            Console.Write("; } está disponível para leitura e atribuição de valores fora do contexto da classe");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("public void ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Decolar", ConsoleColor.Yellow);
            Console.Write("() e ");
            ConsoleHelper.Escrever("Pousar", ConsoleColor.Yellow);
            Console.Write("() estão disponíveis para serem invocados fora do contexto da classe");
            Console.WriteLine();
            Console.Write("> ");
            ConsoleHelper.Escrever("private void ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("AbrirTremDePouso", ConsoleColor.Yellow);
            Console.Write("() e ");
            ConsoleHelper.Escrever("RecolherTremDePouso", ConsoleColor.Yellow);
            Console.Write("() estão disponíveis somente no contexto da classe");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
