using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_6
{
    public class Exercicio6
    {
        public Exercicio6()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 6");

            int dois = 2;
            InteiroMaisUm(dois);
            Console.WriteLine($"Chamada de método por tipo de Valor: {dois}");

            int doisREF = 2; // Se não atribuir o valor, dá pau
            InteiroMaisUmREF(ref doisREF);
            Console.WriteLine($"Chamada de método por tipo de Valor com REF: {doisREF}");

            int doisOUT = 2; // DESNECESSÁRIO, pois o valor "2" não pode ser utilizado dentro do método (será sobrescrito o valor)
            InteiroMaisUmOUT(out doisOUT);
            Console.WriteLine($"Chamada de método por tipo de Valor com OUT: {doisOUT}");
            //InteiroMaisUmOUT(out int doisOUT); // Dessa maneira o método é chamado já criando uma variável sem a necessidade de declará-la explicitamente

            var classeDois = new Dois();
            ClasseMaisUm(classeDois);
            Console.WriteLine($"Chamada de método por tipo de Referência: {classeDois.Inteiro}");

            var classeDoisREF = new Dois();
            ClasseMaisUmREF(ref classeDoisREF); // DESNECESSÁRIO usar REF, pois todas as chamadas com parâmetros classes são de referência
            Console.WriteLine($"Chamada de método por tipo de Referência com REF: {classeDoisREF.Inteiro}");

            var classeDoisOUT = new Dois(); // DESNECESSÁRIO, pois a instancia não pode ser utilizada dentro do método (será sobrescrita a instância)
            ClasseMaisUmOUT(out classeDoisOUT);
            Console.WriteLine($"Chamada de método por tipo de Referência com OUT: {classeDoisOUT.Inteiro}");
            //ClasseMaisUmOUT(out Dois classeDoisOUT); // Dessa maneira o método é chamado já criando uma variável sem a necessidade de declará-la explicitamente
        }

        void InteiroMaisUm(int inteiro)
        {
            // O parâmetro de tipo int e todos os tipos primitivos do C#
            // (herdam diretamente de struct) utilizam a passagem de
            // parâmetro por VALOR. O que significa que ao entrar nesse método,
            // o *inteiro* agora é uma cópia do valor original. Ao atribuir o
            // *inteiro++* não será refletido na variável original, apenas na
            // variável deste escopo.

            inteiro++;
        }

        void InteiroMaisUmREF(ref int inteiro)
        {
            // Necessariamente para invocar esse método é obrigatório que
            // o valor original de *inteiro* seja atribuído antes da chamada,
            // pois esse método poderá (ou não) substituir o valor original.
            // Agora tudo que ocorrer com a variável local deste escopo, será
            // refletido à variável original.

            inteiro++;
        }

        void InteiroMaisUmOUT(out int inteiro)
        {
            // Necessariamente esse método será obrigado a atribuir um valor
            // para o parâmetro *inteiro* neste escopo, que será refletido na variável
            // original, ignorando o valor que foi passado. (Necessário inicializar
            // a variável *inteiro*).

            inteiro = 999;

            inteiro++;
        }

        void ClasseMaisUm(Dois dois)
        {
            // Toda chamada de método com parâmetro do tipo Class é uma chamada
            // por tido de referência, logo, os dados modificados neste escopo
            // serão refletidos na variável original.

            dois.Inteiro += 1;
        }

        void ClasseMaisUmREF(ref Dois dois)
        {
            // Não tem diferença comparado ao método void ClasseMaisUm(Dois dois).
            // Se mostra desnecessário o uso de ref para classes.

            dois.Inteiro += 1;
        }

        void ClasseMaisUmOUT(out Dois dois)
        {
            // Necessariamente esse método será obrigado a instanciar uma nova
            // classe ou atribuir um valor á ela neste escopo que será refletido
            // na variável original, ignorando a instância toda que foi passada
            // por parâmetro.

            dois = new Dois() { Inteiro = 999 };

            dois.Inteiro += 1;
        }
    }
}
