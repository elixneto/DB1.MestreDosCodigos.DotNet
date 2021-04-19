using System;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2
{
    public class Exercicio2
    {
        Funcionario[] Funcionarios;
        int MenorSalario = int.MaxValue;
        int MaiorSalario = int.MinValue;

        public Exercicio2()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 2");

            var quantidadeDeFuncionarios = ConsoleHelper.LerInteiro("Informe o total de funcionarios:");

            Funcionarios = new Funcionario[quantidadeDeFuncionarios];

            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                Console.WriteLine("Informe o nome do novo funcionário:");
                var nome = Console.ReadLine();
                var salario = ConsoleHelper.LerInteiro($"Informe o salário de '{nome}':");

                Funcionarios[i] = new Funcionario(nome, salario);
            }

            ImprimirMenorEMaiorSalariosComFOR();

            ResetarMenorEMaiorSalarios();

            ImprimirMenorEMaiorSalariosComWHILE();
        }

        void ImprimirMenorEMaiorSalariosComFOR()
        {
            for (int i = 0; i < Funcionarios.Length; i++)
            {
                var salario = Funcionarios[i].Salario;

                if (salario < MenorSalario)
                {
                    MenorSalario = salario;
                }

                if (salario > MaiorSalario)
                {
                    MaiorSalario = salario;
                }
            }

            Console.WriteLine($"(FOR) Maior Salário = {MaiorSalario}");
            Console.WriteLine($"(FOR) Menor Salário = {MenorSalario}");
        }

        void ImprimirMenorEMaiorSalariosComWHILE()
        {
            int i = 0;
            while (i < Funcionarios.Length)
            {
                var salario = Funcionarios[i].Salario;

                if (salario < MenorSalario)
                {
                    MenorSalario = salario;
                }

                if (salario > MaiorSalario)
                {
                    MaiorSalario = salario;
                }

                i++;
            }

            Console.WriteLine($"(WHILE) Maior Salário = {MaiorSalario}");
            Console.WriteLine($"(WHILE) Menor Salário = {MenorSalario}");
        }

        void ResetarMenorEMaiorSalarios()
        {
            MenorSalario = int.MaxValue;
            MaiorSalario = int.MinValue;
        }
    }
}
