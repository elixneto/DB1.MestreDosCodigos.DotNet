using System;
using System.Collections.Generic;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_4
{
    public class Exercicio4
    {
        List<Aluno> Alunos;

        public Exercicio4()
        {
            MostrarTexto();

            var quantidadeDeAlunos = ConsoleHelper.LerInteiro("Informe o total de alunos:");

            Alunos = new List<Aluno>(quantidadeDeAlunos);

            for (int i = 0; i < quantidadeDeAlunos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Informe o nome do {(i + 1)}º aluno:");
                var nome = Console.ReadLine();

                var novoAluno = new Aluno(nome);

                var n = 0;
                while (n < Aluno.QuantidadeDeNotas)
                {
                    novoAluno.Notas[n] = ConsoleHelper.LerDecimal($"Informe a {(n + 1)}ª nota de '{novoAluno.Nome}':");
                    n++;
                }

                Alunos.Add(novoAluno);
            }

            ImprimirAlunosComMediaMaiorQue7();
        }

        void ImprimirAlunosComMediaMaiorQue7()
        {
            ConsoleHelper.Subtitulo("Imprima todos os alunos com médias superiores a 7");

            foreach (var aluno in Alunos)
            {
                var somaDasNotas = 0m;

                foreach (var nota in aluno.Notas)
                {
                    somaDasNotas += nota;
                }

                var media = somaDasNotas / Aluno.QuantidadeDeNotas;

                if (media > 7m)
                {
                    Console.WriteLine($"- {aluno.Nome} | média {media}");
                }
            }

            Console.WriteLine();
            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_4", "Exercicio4", 43);
        }

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 4",
                "Faça uma aplicação que receba N alunos com suas respectivas notas. User foreach para estrutura de repetição:",
                " - Crie um objeto Alunos",
                " - Armazene os alunos em uma lista");

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_4", "Aluno");
            Console.WriteLine();
        }
    }
}
