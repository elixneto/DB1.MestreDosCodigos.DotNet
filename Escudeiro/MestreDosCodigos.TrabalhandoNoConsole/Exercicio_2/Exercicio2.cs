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
            MostrarTexto();

            var quantidadeDeFuncionarios = ConsoleHelper.LerInteiro("Informe o total de funcionarios:");

            Funcionarios = new Funcionario[quantidadeDeFuncionarios];

            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                Console.WriteLine($"Informe o nome do {(i + 1)}º funcionário:");
                var nome = Console.ReadLine();
                var salario = ConsoleHelper.LerInteiro($"Informe o salário de '{nome}':");

                Funcionarios[i] = new Funcionario(nome, salario);
            }

            ConsoleHelper.Subtitulo("Imprima o maior e o menor salário");

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

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2", "Exercicio2", 37);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2", "Exercicio2", 30);
            Console.WriteLine();
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

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2", "Exercicio2", 62);
            ConsoleHelper.VideChamada("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2", "Exercicio2", 34);
            Console.WriteLine();
        }

        void ResetarMenorEMaiorSalarios()
        {
            MenorSalario = int.MaxValue;
            MaiorSalario = int.MinValue;
        }

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 2",
                "Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while");

            ConsoleHelper.VideClasse("MestreDosCodigos.TrabalhandoNoConsole.Exercicio_2", "Funcionario");
            Console.WriteLine();
        }
    }
}
