using System;

namespace MestreDosCodigos.TrabalhandoNoConsole
{
    public static class ConsoleHelper
    {
        public static void Cabecalho(string titulo)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(titulo);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }

        public static int LerInteiro(string mensagem = default)
        {
            if(!string.IsNullOrEmpty(mensagem))
            {
                Console.WriteLine(mensagem);
            }
            
            var entradaDoUsuario = Console.ReadLine();

            if (!int.TryParse(entradaDoUsuario, out int numero))
            {
                throw new Exception("O valor informado não é um inteiro!");
            }

            return numero;
        }

        public static decimal LerDecimal(string mensagem = default)
        {
            if (!string.IsNullOrEmpty(mensagem))
            {
                Console.WriteLine(mensagem);
            }

            var entradaDoUsuario = Console.ReadLine();
            var entradaEhVazia = string.IsNullOrWhiteSpace(entradaDoUsuario);

            if (entradaEhVazia)
            {
                throw new Exception("O valor não foi informado");
            }

            entradaDoUsuario = entradaDoUsuario.Replace(".", ",");

            var conversaoInvalida = !decimal.TryParse(entradaDoUsuario, out decimal numero);

            if (entradaEhVazia || conversaoInvalida)
            {
                throw new Exception("O valor informado não é um decimal!");
            }

            return numero;
        }

        public static double LerDouble(string mensagem)
        {
            if (!string.IsNullOrEmpty(mensagem))
            {
                Console.WriteLine(mensagem);
            }

            var entradaDoUsuario = Console.ReadLine();
            var entradaEhVazia = string.IsNullOrWhiteSpace(entradaDoUsuario);

            if (entradaEhVazia)
            {
                throw new Exception("O valor não foi informado");
            }

            entradaDoUsuario = entradaDoUsuario.Replace(".", ",");

            var conversaoInvalida = !double.TryParse(entradaDoUsuario, out double numero);

            if (entradaEhVazia || conversaoInvalida)
            {
                throw new Exception("O valor informado não é um decimal!");
            }

            return numero;
        }
    }
}
