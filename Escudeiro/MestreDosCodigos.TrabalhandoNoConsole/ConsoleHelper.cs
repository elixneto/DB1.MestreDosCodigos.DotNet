using System;

namespace MestreDosCodigos.TrabalhandoNoConsole
{
    public static class ConsoleHelper
    {
        public static void Cabecalho(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------");
            EscreverLinha(titulo, ConsoleColor.DarkCyan);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }

        public static void Subtitulo(string subtitulo, params string[] descricoes)
        {
            PressioneEnter(subtitulo);

            Console.WriteLine();
            Console.Write("--|   ");
            Escrever(subtitulo, ConsoleColor.DarkCyan);
            Console.Write(":");
            Console.WriteLine();

            foreach(var descricao in descricoes)
            {
                Escrever(descricao, ConsoleColor.DarkGray);
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PressioneEnter(string texto)
        {
            Console.WriteLine();
            Escrever(texto, ConsoleColor.DarkCyan);
            Console.Write("  Pressione qualquer tecla para continuar ...");

            Console.ReadKey();

            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
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

        public static void Escrever(string palavras, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(palavras);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void EscreverLinha(string palavras, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(palavras);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
