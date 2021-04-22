using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6
{
    public class Exercicio6
    {
        public Exercicio6()
        {
            MostrarTexto();

            ConsoleHelper.Subtitulo("Chamada de int como parâmetro");
            
            {
                int dois = 2;
                InteiroMaisUm(dois);
                Console.WriteLine($"> 2 + 1 = {dois}");
            }

            ConsoleHelper.Subtitulo("Chamada de int ref como parâmetro");

            {
                int doisREF = 2;
                InteiroMaisUmREF(ref doisREF);
                Console.WriteLine($"> 2 + 1 = {doisREF}");
            }

            ConsoleHelper.Subtitulo("Chamada de int out como parâmetro");

            {
                int doisOUT = 2;
                InteiroMaisUmOUT(out doisOUT);
                Console.WriteLine($"> 2 (999) + 1 = {doisOUT}");
                //InteiroMaisUmOUT(out int doisOUT); // Dessa maneira o método é chamado já criando uma variável sem a necessidade de declará-la explicitamente
            }

            ConsoleHelper.Subtitulo("Chamada de class como parâmetro");

            {
                var classeDois = new Dois();
                ClasseMaisUm(classeDois);
                Console.WriteLine($"> 2 + 1 = {classeDois.Inteiro}");
            }

            ConsoleHelper.Subtitulo("Chamada de class ref como parâmetro");

            {
                var classeDoisREF = new Dois();
                ClasseMaisUmREF(ref classeDoisREF); // DESNECESSÁRIO usar REF
                Console.WriteLine($"> 2 + 1 = {classeDoisREF.Inteiro}");
            }

            ConsoleHelper.Subtitulo("Chamada de class out como parâmetro");

            {
                var classeDoisOUT = new Dois();
                ClasseMaisUmOUT(out classeDoisOUT);
                Console.WriteLine($"> 2 (999) + 1 = {classeDoisOUT.Inteiro}");
                //ClasseMaisUmOUT(out Dois classeDoisOUT); // Dessa maneira o método é chamado já criando uma variável sem a necessidade de declará-la explicitamente
            }
        }

        void InteiroMaisUm(int inteiro)
        {
            ConsoleHelper.EscreverLinha("O parâmetro de tipo int e todos os tipos primitivos do C# (herdam diretamente de struct) utilizam a passagem de parâmetro por VALOR.", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("O que significa que ao entrar nesse método, o *inteiro* agora é uma cópia do valor original.", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("Ao atribuir o *inteiro++* não será refletido na variável original, apenas na variável deste escopo (a cópia).", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 13);
            Console.WriteLine();

            inteiro++;
        }

        void InteiroMaisUmREF(ref int inteiro)
        {
            ConsoleHelper.EscreverLinha("Necessariamente para invocar esse método é obrigatório que o valor original de *inteiro* seja atribuído antes da chamada pois esse método poderá (ou não) substituir o valor original.", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("Agora tudo que ocorrer com a variável local deste escopo, será refletido à variável original.", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 21);
            Console.WriteLine();

            inteiro++;
        }

        void InteiroMaisUmOUT(out int inteiro)
        {
            ConsoleHelper.EscreverLinha("Necessariamente esse método será obrigado a atribuir um valor para o parâmetro *inteiro* neste escopo, que será refletido na variável original, ignorando o valor que foi passado.", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("(É obrigatório inicializar a variável *inteiro*).", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("InteiroMaisUmOUT(out int doisOUT); Dessa maneira o método é chamado já criando uma variável sem a necessidade de declará-la explicitamente", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 29);
            Console.WriteLine();

            inteiro = 999;

            inteiro++;
        }

        void ClasseMaisUm(Dois dois)
        {
            ConsoleHelper.EscreverLinha("Toda chamada de método com parâmetro do tipo Class é uma chamada por tipo de REFERÊNCIA (diferente dos tipos primitivos que são por valor).", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("Logo, os dados modificados neste escopo serão sempre refletidos no objeto original.", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 38);
            Console.WriteLine();

            dois.Inteiro += 1;
        }

        void ClasseMaisUmREF(ref Dois dois)
        {
            ConsoleHelper.EscreverLinha("É desnecessário o uso de ref para parâmetros do tipo Class, pois todos os parâmetros já são por REFERÊNCIA.", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 46);
            Console.WriteLine();

            dois.Inteiro += 1;
        }

        void ClasseMaisUmOUT(out Dois dois)
        {
            ConsoleHelper.EscreverLinha("Necessariamente esse método será obrigado a instanciar uma nova classe ou atribuir um valor á ela neste escopo.", ConsoleColor.Yellow);
            ConsoleHelper.EscreverLinha("Todos os dados modificados serão refletidos no objeto original, ignorando a instância toda que foi passada por parâmetro.", ConsoleColor.Yellow);
            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6", "Exercicio6", 54);
            Console.WriteLine();

            dois = new Dois() { Inteiro = 999 };

            dois.Inteiro += 1;
        }

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 6",
                "Crie uma aplicação que demonstre a diferença entre REF e OUT");

            Console.WriteLine();
        }
    }
}
