using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_2
{
    public class Exercicio2
    {
        public Exercicio2()
        {
            MostrarTexto();

            var pessoa = new Pessoa();

            pessoa.AlterarNome("Élix Neto");
            pessoa.AlterarDataDeNascimento(new DateTime(1993, 4, 18));
            pessoa.AlterarAltura(1.73m);

            Console.WriteLine(pessoa);
        }

        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 2",
                "Crie uma classe para representar uma pessoa:",
                " - Crie os atributos privados de nome, data de nascimento e altura",
                " - Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos os dados de uma pessoa",
                " - Crie um método para calcular a idade da pessoa",
                " - Imprima os dados via console");

            ConsoleHelper.PressioneEnter();

            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_2", "Pessoa");
            Console.WriteLine();
        }
    }
}
