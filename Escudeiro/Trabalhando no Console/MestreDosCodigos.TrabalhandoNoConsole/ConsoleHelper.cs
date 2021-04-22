using System;
using System.Linq;

namespace MestreDosCodigos.TrabalhandoNoConsole
{
    public static class ConsoleHelper
    {
        public static void Cabecalho(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            EscreverLinha(titulo, ConsoleColor.DarkCyan);
            Console.WriteLine("-----------------");
            Console.WriteLine();
        }
        public static void Cabecalho(string titulo, string descricao)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            EscreverLinha(titulo, ConsoleColor.DarkCyan);
            Console.WriteLine("-----------------");
            PressioneEnter();
            Escrever(descricao, ConsoleColor.DarkGray);
            Console.WriteLine();
        }
        public static void Cabecalho(string titulo, params string[] descricoes)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            EscreverLinha(titulo, ConsoleColor.DarkCyan);
            Console.WriteLine("-----------------");
            PressioneEnter();
            foreach (var descricao in descricoes)
            {
                Escrever(descricao, ConsoleColor.DarkGray);
                Console.WriteLine();
            }
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

            foreach (var descricao in descricoes)
            {
                Escrever(descricao, ConsoleColor.DarkGray);
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PressioneEnter(string texto = default)
        {
            Console.WriteLine();
            Escrever(texto, ConsoleColor.DarkCyan);
            Console.Write("  Pressione qualquer tecla para continuar ...");

            Console.ReadKey();

            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public static int LerInteiro(string mensagem = default)
        {
            if (!string.IsNullOrEmpty(mensagem))
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

        public static void VideClasse(string @namespace, string classe)
        {
            Console.Write("implementado em [");
            Escrever(@namespace + ".", ConsoleColor.Gray);
            Escrever(classe + ".cs", ConsoleColor.DarkGreen);
            Console.Write("]");

            Console.WriteLine();
        }

        public static void VideClasse(string @namespace, string classe, int linha)
        {
            Console.Write("implementado em [");
            Escrever(@namespace + ".", ConsoleColor.Gray);
            Escrever(classe + ".cs", ConsoleColor.DarkGreen);
            Console.Write("] linha " + linha);

            Console.WriteLine();
        }

        public static void VideClasse(string @namespace, string classe, params int[] linhas)
        {
            Console.Write("implementado em [");
            Escrever(@namespace + ".", ConsoleColor.Gray);
            Escrever(classe + ".cs", ConsoleColor.DarkGreen);
            Console.Write("] linhas " + linhas.Select(l => l.ToString()).Aggregate((i, j) => i + ", " + j));

            Console.WriteLine();
        }

        public static void VideInterface(string @namespace, string classe)
        {
            Console.Write("implementado em [");
            Escrever(@namespace + ".", ConsoleColor.Gray);
            Escrever(classe + ".cs]", ConsoleColor.DarkYellow);

            Console.WriteLine();
        }

        public static void VideChamada(string @namespace, string classe, int linha)
        {
            Console.Write("invocado em [");
            Escrever(@namespace + ".", ConsoleColor.Gray);
            Escrever(classe + ".cs", ConsoleColor.DarkGreen);
            Console.Write("] linha " + linha);

            Console.WriteLine();
        }

        public static void MestreDosCodigos_Fade()
        {
            PressioneEnter();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("@@@@@@@@@@  @@@@@@@@  @@@@@@ @@@@@@@ @@@@@@@  @@@@@@@@    @@@@@@@   @@@@@@   @@@@@@     @@@@@@@  @@@@@@  @@@@@@@  @@@  @@@@@@@   @@@@@@   @@@@@@");
            Console.WriteLine("@@! @@! @@! @@!      !@@       @!!   @@!  @@@ @@!         @@!  @@@ @@!  @@@ !@@        !@@      @@!  @@@ @@!  @@@ @@! !@@       @@!  @@@ !@@    ");
            Console.WriteLine("@!!!!!@ @!@ @!!!:!    !@@!!    @!!   @!@!!@!  @!!!:!      @!@  !@! @!@  !@!  !@@!!     !@!      @!@  !@! @!@  !@! !!@ !@! @!@!@ @!@  !@!  !@@!!");
            Console.WriteLine("!!:     !!: !!:          !:!   !!:   !!: :!!  !!:         !!:  !!! !!:  !!!     !:!    :!!      !!:  !!! !!:  !!! !!: :!!   !!: !!:  !!!     !:!");
            Console.WriteLine(" :      :   : :: ::  ::.: :     :     :   : : : :: ::     :: :  :   : :. :  ::.: :      :: :: :  : :. :  :: :  :  :    :: :: :   : :. :  ::.: : ");
            Console.WriteLine();
            Console.WriteLine("================================================================================================================================================");
            Console.WriteLine();
        }

        public static void MestreDosCodigos_Doom()
        {
            PressioneEnter();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================================================================");
            Console.WriteLine(@"  ___  ___          _                  _             _____           _ _                 ");
            Console.WriteLine(@"  |  \/  |         | |                | |           /  __ \         | (_)                ");
            Console.WriteLine(@"  | .  . | ___  ___| |_ _ __ ___    __| | ___  ___  | /  \/ ___   __| |_  __ _  ___  ___ ");
            Console.WriteLine(@"  | |\/| |/ _ \/ __| __| '__/ _ \  / _` |/ _ \/ __| | |    / _ \ / _` | |/ _` |/ _ \/ __|");
            Console.WriteLine(@"  | |  | |  __/\__ \ |_| | |  __/ | (_| | (_) \__ \ | \__/\ (_) | (_| | | (_| | (_) \__ \");
            Console.WriteLine(@"  \_|  |_/\___||___/\__|_|  \___|  \__,_|\___/|___/  \____/\___/ \__,_|_|\__, |\___/|___/");
            Console.WriteLine(@"                                                                          __/ |          ");
            Console.WriteLine(@"                                                                         |___/           ");
            Console.WriteLine("===========================================================================================");
            Console.WriteLine();
        }
    }
}
