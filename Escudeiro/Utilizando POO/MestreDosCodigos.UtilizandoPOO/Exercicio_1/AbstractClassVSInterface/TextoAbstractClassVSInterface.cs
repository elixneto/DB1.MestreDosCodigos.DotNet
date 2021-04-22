using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface
{
    public static class TextoAbstractClassVSInterface
    {
        public static void Mostrar()
        {
            ConsoleHelper.VideInterface("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface", "Ligavel");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface", "Ventilador");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface", "Lampada");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores", "Computador");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores", "NotebookSAMSUNG");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores", "NotebookLENOVO");

            Console.WriteLine();

            Console.Write("> As classes ");
            ConsoleHelper.Escrever("Ventilador", ConsoleColor.Green);
            Console.Write(" e ");
            ConsoleHelper.Escrever("Lampada", ConsoleColor.Green);
            Console.Write(" herdam da interface ");
            ConsoleHelper.Escrever("Ligavel", ConsoleColor.Yellow);
            Console.Write(" e devem, necessariamente, implementar todos os métodos declarados nessa interface");
            Console.WriteLine();
            Console.Write("> As classes ");
            ConsoleHelper.Escrever("NotebookSAMSUNG", ConsoleColor.Green);
            Console.Write(" e ");
            ConsoleHelper.Escrever("NotebookLENOVO", ConsoleColor.Green);
            Console.Write(" herdam da classe abstrata ");
            ConsoleHelper.Escrever("Computador", ConsoleColor.Green);
            Console.Write(" que possui métodos ");
            ConsoleHelper.Escrever("virtual", ConsoleColor.Blue);
            Console.Write(" permitindo a sobrescrita, ou não, do comportamento nas classes derivadas");
            Console.WriteLine();
            Console.Write("> A palavra-chave ");
            ConsoleHelper.Escrever("abstract", ConsoleColor.Blue);
            Console.Write(" no método ");
            ConsoleHelper.Escrever("PressionarTecla(", ConsoleColor.Yellow);
            ConsoleHelper.Escrever("char", ConsoleColor.Blue);
            Console.Write(" tecla) da classe abstrata ");
            ConsoleHelper.Escrever("Computador", ConsoleColor.Green);
            Console.Write(", obriga todas as classes derivadas a implementarem esse método sem um comportamento padrão");
            Console.WriteLine();
            Console.Write("> Todos os métodos na classe abstrata ");
            ConsoleHelper.Escrever("Computador", ConsoleColor.Green);
            Console.Write(" que possuem a palavra-chave ");
            ConsoleHelper.Escrever("virtual", ConsoleColor.Blue);
            Console.Write(" permitem sobreescrita inclusive executando o comportamento padrão.");
            Console.WriteLine();
            Console.Write("A classe derivada ");
            ConsoleHelper.Escrever("NotebookSAMSUNG", ConsoleColor.Green);
            Console.Write(", faz isso sobrescrevendo (");
            ConsoleHelper.Escrever("override", ConsoleColor.Blue);
            Console.Write(") o método ");
            ConsoleHelper.Escrever("Ligar", ConsoleColor.Yellow);
            Console.Write("() e em sua implementação invocando o método ");
            ConsoleHelper.Escrever("base", ConsoleColor.Blue);
            Console.Write(".");
            ConsoleHelper.Escrever("Ligar", ConsoleColor.Yellow);
            Console.Write("();");

            Console.WriteLine();
            ConsoleHelper.PressioneEnter();
            Console.WriteLine();
        }
    }
}
