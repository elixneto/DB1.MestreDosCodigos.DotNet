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
        }

        private void ImprimirCrescente()
        {
            ConsoleHelper.Subtitulo("Imprimir todos os números da lista na ordem crescente",
                "> .OrderBy(n => n)");

            var listaCrescente = ListaDeInteiros.OrderBy(n => n); // .OrderBy() é LINQ

            ImprimirPorEnumeracao(listaCrescente);

            Console.WriteLine();
        }

        private void ImprimirDecrescente()
        {
            ConsoleHelper.Subtitulo("Imprimir todos os números da lista na ordem decrescente",
                "> .OrderByDescending(n => n)");

            var listaCrescente = ListaDeInteiros.OrderByDescending(n => n); // .OrderByDescending() é LINQ

            ImprimirPorEnumeracao(listaCrescente);

            Console.WriteLine();
        }

        private void ImprimirPrimeiroNumero()
        {
            ConsoleHelper.Subtitulo("Imprima apenas o primeiro número da lista",
                "> .First()");

            var primeiroNumero = ListaDeInteiros.First(); // .First() é LINQ

            Console.WriteLine(primeiroNumero);

            Console.WriteLine();
        }

        private void ImprimirUltimoNumero()
        {
            ConsoleHelper.Subtitulo("Imprima apenas o último número da lista",
                "> .Last()");

            var ultimoNumero = ListaDeInteiros.Last(); // .Last() é LINQ

            Console.WriteLine(ultimoNumero);

            Console.WriteLine();
        }

        private void InserirNumeroNoInicio()
        {
            ConsoleHelper.Subtitulo("Insira um número no início da lista",
                "> .Insert(0, numeroParaInserir) não é LINQ, é da própria List<T>");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no início da lista:");

            ListaDeInteiros.Insert(0, numeroParaInserir); // .Insert não é LINQ, é da própria List<T>

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);
        }

        private void InserirNumeroNoFinal()
        {
            ConsoleHelper.Subtitulo("Insira um número no final da lista",
                "> .Add(numeroParaInserir) não é LINQ, é da própria List<T> e sempre insere no final da lista");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no final da lista:");

            ListaDeInteiros.Add(numeroParaInserir); // .Add não é LINQ, é da própria List<T>

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);
        }

        private void RemoverOPrimeiroNumero()
        {
            ConsoleHelper.Subtitulo("Remova o primeiro número",
                "> .RemoveAt(0) não é LINQ, é da própria List<T>");

            ListaDeInteiros.RemoveAt(0); // .RemoveAt não é LINQ, é da própria List<T>

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);
        }

        private void RemoverUltimoNumero()
        {
            ConsoleHelper.Subtitulo("Remova o último número",
                "> .RemoveAt(quantidade - 1) não é LINQ, é da própria List<T>");

            var indiceDoUltimoNumero = ListaDeInteiros.Count - 1;

            ListaDeInteiros.RemoveAt(indiceDoUltimoNumero); // .RemoveAt não é LINQ, é da própria List<T>

            Console.WriteLine();

            ImprimirPorEnumeracao(ListaDeInteiros);
        }

        private void ImprimirPares()
        {
            ConsoleHelper.Subtitulo("Retorne apenas os números pares",
                "> .Where(n => (n % 2) == 0)");

            var pares = ListaDeInteiros.Where(n => (n % 2) == 0); // .Where é LINQ

            ImprimirPorEnumeracao(pares);

            Console.WriteLine();
        }

        private void ImprimirNumeroInformado()
        {
            ConsoleHelper.Subtitulo("Retorne apenas o número informado",
                "> .FirstOrDefault(n => n == numeroInformado) | .IndexOf(numeroInformado) não é LINQ, é da própria List<T>");

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
        }

        private void ImprimirArray()
        {
            ConsoleHelper.Subtitulo("Tranforme todos os números da lista em um Array",
                "> .Select(n => n.ToString()) | .Aggregate((i, j) => i + \", \" + j)");

            var array = ListaDeInteiros.ToArray();

            Console.WriteLine("ARRAY");

            var numerosConcatenadosPorVirgula = array.Select(n => n.ToString())         // .Select é LINQ
                                                     .Aggregate((i, j) => i + ", " + j); // .Aggregate é LINQ

            Console.WriteLine(numerosConcatenadosPorVirgula);
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
