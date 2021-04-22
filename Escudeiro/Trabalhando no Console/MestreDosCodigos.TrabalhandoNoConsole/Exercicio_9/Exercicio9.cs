using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9
{
    public class Exercicio9
    {
        List<int> ListaDeInteiros;

        public Exercicio9()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 9",
                "Utilizando a biblioteca LINQ crie no console e execute:");

            Console.WriteLine();

            ListaDeInteiros = new List<int>(10) { 7, 4, 6, 3, 5, 2, 10, 1, 9, 8 };

            ImprimirTodos();
            ImprimirCrescente();
            ImprimirDecrescente();
            ImprimirPrimeiroNumero();
            ImprimirUltimoNumero();
            InserirNumeroNoInicio();
            InserirNumeroNoFinal();
            RemoverOPrimeiroNumero();
            RemoverUltimoNumero();
            ImprimirPares();
            ImprimirNumeroInformado();
            ImprimirArray();
        }

        private void ImprimirTodos()
        {
            ConsoleHelper.Subtitulo("Imprimir todos os números da lista");

            ListaDeInteiros.ForEach(n => Console.WriteLine(n));

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 38);
        }

        private void ImprimirCrescente()
        {
            ConsoleHelper.Subtitulo("Imprimir todos os números da lista na ordem crescente",
                "> .OrderBy(n => n)");

            var listaCrescente = ListaDeInteiros.OrderBy(n => n);

            ImprimirPorEnumeracao(listaCrescente);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 48);
            Console.WriteLine();
        }

        private void ImprimirDecrescente()
        {
            ConsoleHelper.Subtitulo("Imprimir todos os números da lista na ordem decrescente",
                "> .OrderByDescending(n => n)");

            var listaCrescente = ListaDeInteiros.OrderByDescending(n => n);

            ImprimirPorEnumeracao(listaCrescente);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 61);
            Console.WriteLine();
        }

        private void ImprimirPrimeiroNumero()
        {
            ConsoleHelper.Subtitulo("Imprima apenas o primeiro número da lista",
                "> .First()");

            var primeiroNumero = ListaDeInteiros.First();

            Console.WriteLine(primeiroNumero);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 74);
            Console.WriteLine();
        }

        private void ImprimirUltimoNumero()
        {
            ConsoleHelper.Subtitulo("Imprima apenas o último número da lista",
                "> .Last()");

            var ultimoNumero = ListaDeInteiros.Last();

            Console.WriteLine(ultimoNumero);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 87);
            Console.WriteLine();
        }

        private void InserirNumeroNoInicio()
        {
            ConsoleHelper.Subtitulo("Insira um número no início da lista",
                "> .Insert(0, numeroParaInserir) não é LINQ, é da própria List<T>");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no início da lista:");

            ListaDeInteiros.Insert(0, numeroParaInserir);

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 102);
        }

        private void InserirNumeroNoFinal()
        {
            ConsoleHelper.Subtitulo("Insira um número no final da lista",
                "> .Add(numeroParaInserir) não é LINQ, é da própria List<T> e sempre insere no final da lista");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no final da lista:");

            ListaDeInteiros.Add(numeroParaInserir);

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 118);
        }

        private void RemoverOPrimeiroNumero()
        {
            ConsoleHelper.Subtitulo("Remova o primeiro número",
                "> .RemoveAt(0) não é LINQ, é da própria List<T>");

            ListaDeInteiros.RemoveAt(0);

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 132);
        }

        private void RemoverUltimoNumero()
        {
            ConsoleHelper.Subtitulo("Remova o último número",
                "> .RemoveAt(quantidade - 1) não é LINQ, é da própria List<T>");

            var indiceDoUltimoNumero = ListaDeInteiros.Count - 1;

            ListaDeInteiros.RemoveAt(indiceDoUltimoNumero);

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 148);
        }

        private void ImprimirPares()
        {
            ConsoleHelper.Subtitulo("Retorne apenas os números pares",
                "> .Where(n => (n % 2) == 0)");

            var pares = ListaDeInteiros.Where(n => (n % 2) == 0); // .Where é LINQ

            ImprimirPorEnumeracao(pares);

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 162);
            Console.WriteLine();
        }

        private void ImprimirNumeroInformado()
        {
            ConsoleHelper.Subtitulo("Retorne apenas o número informado",
                "> .FirstOrDefault(n => n == numeroInformado)",
                "> .IndexOf(numeroInformado) não é LINQ, é da própria List<T>");

            var numeroInformado = ConsoleHelper.LerInteiro("Informe um número para ser pesquisado:");

            var numeroEncontrado = ListaDeInteiros.FirstOrDefault(n => n == numeroInformado); // .FirstOrDefault é LINQ
            if (numeroEncontrado == default)
            {
                Console.WriteLine($"***** Número {numeroInformado} não encontrado");
                Console.WriteLine();
                return;
            }

            var indiceDoNumeroEncontrado = ListaDeInteiros.IndexOf(numeroEncontrado); // .IndexOf não é LINQ, é da própria List<T>

            Console.WriteLine($"***** Primeira ocorrência do Número {numeroInformado} = posição {indiceDoNumeroEncontrado} :: zero-based index");
            Console.WriteLine();

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 177);
            Console.WriteLine();
        }

        private void ImprimirArray()
        {
            ConsoleHelper.Subtitulo("Tranforme todos os números da lista em um Array",
                "> .ToArray() não é LINQ, é da própria List<T>",
                "> .Select(n => n.ToString())",
                "> .Aggregate((i, j) => i + \", \" + j)");

            var array = ListaDeInteiros.ToArray();

            Console.WriteLine("ARRAY");

            var numerosConcatenadosComVirgula = array.Select(n => n.ToString())         // .Select é LINQ
                                                     .Aggregate((i, j) => i + ", " + j); // .Aggregate é LINQ

            Console.WriteLine("[" + numerosConcatenadosComVirgula + "]");

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_9", "Exercicio9", 200);
        }


        private void ImprimirPorEnumeracao(IEnumerable<int> numeros)
        {
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
