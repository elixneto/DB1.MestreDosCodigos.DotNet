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
            ConsoleHelper.Cabecalho("EXERCICIO 9");

            ListaDeInteiros = new List<int>(10) { 5, 4, 6, 3, 7, 2, 8, 1, 9, 10 };

            ImprimirTodos();
            ImprimirCrescente();
            ImprimirDecrescente();
            ImprimirPrimeiroNumero();
            ImprimirUltimoNumero();
            InserirNumeroNoInicio();
            InserirNumeroNoFinal();
            RemoverUltimoNumero();
            ImprimirPares();
            ImprimirNumeroInformado();
            ImprimirArray();
        }

        private void ImprimirTodos()
        {
            Console.WriteLine("TODOS:");

            ListaDeInteiros.ForEach(n => Console.WriteLine(n));

            Console.WriteLine();
        }

        private void ImprimirCrescente()
        {
            Console.WriteLine("CRESCENTE:");

            var listaCrescente = ListaDeInteiros.OrderBy(n => n); // .OrderBy() é LINQ

            ImprimirPorEnumeracao(listaCrescente);

            Console.WriteLine();
        }

        private void ImprimirDecrescente()
        {
            Console.WriteLine("DECRESCENTE:");

            var listaCrescente = ListaDeInteiros.OrderByDescending(n => n); // .OrderByDescending() é LINQ

            ImprimirPorEnumeracao(listaCrescente);

            Console.WriteLine();
        }

        private void ImprimirPrimeiroNumero()
        {
            Console.WriteLine("PRIMEIRO:");

            var primeiroNumero = ListaDeInteiros.First(); // .First() é LINQ

            Console.WriteLine(primeiroNumero);

            Console.WriteLine();
        }

        private void ImprimirUltimoNumero()
        {
            Console.WriteLine("ÚLTIMO:");

            var ultimoNumero = ListaDeInteiros.Last(); // .Last() é LINQ

            Console.WriteLine(ultimoNumero);

            Console.WriteLine();
        }

        private void InserirNumeroNoInicio()
        {
            Console.WriteLine("INSERIR NO INÍCIO:");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no início da lista:");

            ListaDeInteiros.Insert(0, numeroParaInserir); // .Insert não é LINQ, é da própria List<T>

            Console.WriteLine();
        }

        private void InserirNumeroNoFinal()
        {
            Console.WriteLine("INSERIR NO FINAL:");

            var numeroParaInserir = ConsoleHelper.LerInteiro("Informe um inteiro para adicionar no final da lista:");

            ListaDeInteiros.Add(numeroParaInserir); // .Add não é LINQ, é da própria List<T>

            Console.WriteLine();
        }

        private void RemoverUltimoNumero()
        {
            Console.WriteLine("REMOVER O ULTIMO:");

            var indiceDoUltimoNumero = ListaDeInteiros.Count - 1;

            ListaDeInteiros.RemoveAt(indiceDoUltimoNumero); // .RemoveAt não é LINQ, é da própria List<T>

            Console.WriteLine();
        }

        private void ImprimirPares()
        {
            Console.WriteLine("PARES:");

            var pares = ListaDeInteiros.Where(n => (n % 2) == 0); // .Where é LINQ

            ImprimirPorEnumeracao(pares);

            Console.WriteLine();
        }

        private void ImprimirNumeroInformado()
        {
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
            var array = ListaDeInteiros.ToArray();

            Console.WriteLine("ARRAY");

            var numerosConcatenadosPorVirgula = array.Select(n => n.ToString())         // .Select é LINQ
                                                     .Aggregate((i, j) => i + "," + j); // .Aggregate é LINQ

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
