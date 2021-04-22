using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces
{
    public static class TextoInterfaces
    {
        public static void MostrarIDisposable()
        {
            ConsoleHelper.PressioneEnter("IDisposable");

            Console.Write("> Ao herdar da interface ");
            ConsoleHelper.Escrever("IDisposable", ConsoleColor.Yellow);
            Console.Write(", é necessário implementar o método ");
            ConsoleHelper.Escrever("Dispose", ConsoleColor.Yellow);
            Console.Write("() que é chamado implicitamente dentro de um bloco ");
            ConsoleHelper.Escrever("using", ConsoleColor.Blue);
            Console.Write(" ou diretamente por ");
            ConsoleHelper.Escrever("instanciaDoObjeto", ConsoleColor.Blue);
            Console.Write(".");
            ConsoleHelper.Escrever("Dispose", ConsoleColor.Yellow);
            Console.Write("()");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void MostrarIEnumerable()
        {
            ConsoleHelper.PressioneEnter("IEnumerable");

            Console.WriteLine();
            Console.Write("> Ao herdar da interface ");
            ConsoleHelper.Escrever("IEnumerable", ConsoleColor.Yellow);
            Console.Write(", é necessário implementar o método ");
            ConsoleHelper.Escrever("GetEnumerator", ConsoleColor.Yellow);
            Console.Write("() que é chamado dentro de um bloco ");
            ConsoleHelper.Escrever("foreach", ConsoleColor.Blue);
            Console.Write(" e habilita o loop entre os itens");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void MostrarIComparable()
        {
            ConsoleHelper.PressioneEnter("IComparable");

            Console.WriteLine();
            Console.Write("> Ao herdar da interface ");
            ConsoleHelper.Escrever("IComparable", ConsoleColor.Yellow);
            Console.Write(", é necessário implementar o método ");
            ConsoleHelper.Escrever("int ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("CompareTo", ConsoleColor.Yellow);
            Console.Write("(");
            ConsoleHelper.Escrever("object ", ConsoleColor.Blue);
            Console.Write(" obj) que é chamado dentro de List<T>.Sort()");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void MostrarIClonable()
        {
            ConsoleHelper.PressioneEnter("IClonable");

            Console.WriteLine();
            Console.Write("> Ao herdar da interface ");
            ConsoleHelper.Escrever("IClonable", ConsoleColor.Yellow);
            Console.Write(", é necessário implementar o método ");
            ConsoleHelper.Escrever("object ", ConsoleColor.Blue);
            ConsoleHelper.Escrever("Clone", ConsoleColor.Yellow);
            Console.Write("()");
            Console.WriteLine();
            Console.Write("É importante lembrar que o C# disponibiliza o método ");
            ConsoleHelper.Escrever("MemberwiseClone", ConsoleColor.Yellow);
            Console.Write("() nas classes, porém esse método");
            Console.WriteLine();
            Console.Write("cria uma shallow copy (cópia superficial) no qual os tipos por valor serão copiados mas as referências serão mantidas");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
