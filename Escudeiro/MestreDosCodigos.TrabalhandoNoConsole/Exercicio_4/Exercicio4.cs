using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_4
{
    public class Exercicio4
    {
        List<Aluno> Alunos;

        public Exercicio4()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 4");

            var quantidadeDeAlunos = ConsoleHelper.LerInteiro("Informe o total de alunos:");

            Alunos = new List<Aluno>(quantidadeDeAlunos);

            for (int i = 0; i < quantidadeDeAlunos; i++)
            {
                Console.WriteLine("Informe o nome do novo aluno:");
                var nome = Console.ReadLine();

                var novoAluno = new Aluno(nome);

                Console.WriteLine($"Informe as {Aluno.QuantidadeDeNotas} notas de '{nome}':");

                var n = 0;
                while (n < Aluno.QuantidadeDeNotas)
                {
                    novoAluno.Notas[n] = ConsoleHelper.LerDecimal();
                    n++;
                }

                Alunos.Add(novoAluno);
            }

            ImprimirAlunosComMediaMaiorQue7();
        }

        void ImprimirAlunosComMediaMaiorQue7()
        {
            foreach (var aluno in Alunos)
            {
                var somaDasNotas = 0m;

                foreach(var nota in aluno.Notas)
                {
                    somaDasNotas += nota;
                }

                var media = somaDasNotas / Aluno.QuantidadeDeNotas;

                if (media > 7m)
                {
                    Console.WriteLine($"- {aluno.Nome} | média {media}");
                }
            }
        }
    }
}
