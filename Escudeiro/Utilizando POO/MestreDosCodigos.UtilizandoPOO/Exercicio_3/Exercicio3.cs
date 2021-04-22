using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_3
{
    public class Exercicio3
    {
        public Exercicio3()
        {
            MostrarTexto();

            {
                ContaBancaria contaCorrente = new ContaCorrente(taxaDeOperacao: 0.15);
                ContaBancaria contaEspecial = new ContaEspecial(limite: 1500);

                contaCorrente.MostrarDados();

                ConsoleHelper.PressioneEnter();
                Console.WriteLine("******** Operações *****");

                contaCorrente.Depositar(500);
                contaCorrente.Sacar(400);
                contaCorrente.Sacar(50);

                Console.WriteLine("************************");
                Console.WriteLine();

                ConsoleHelper.PressioneEnter();
                contaCorrente.MostrarDados();

                ConsoleHelper.PressioneEnter();
                contaEspecial.MostrarDados();

                ConsoleHelper.PressioneEnter();
                Console.WriteLine("******** Operações *****");

                contaEspecial.Sacar(320);
                contaEspecial.Sacar(1159);
                contaEspecial.Depositar(52.67);
                contaEspecial.Sacar(1);

                Console.WriteLine("************************");
                Console.WriteLine();

                ConsoleHelper.PressioneEnter();
                contaEspecial.MostrarDados();
            }

            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.UtilizandoPOO.Exercicio_3", "Exercicio3", 12);
        }


        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 3",
                "Faça uma aplicação bancária:",
                " - Crie uma classe abstrata ContaBancaria que contém como atributos, NumeroDaConta e Saldo. E como métodos abstratos Sacar e Depositar que recebem um parâmetro do tipo double",
                " - Crie as classes ContaCorrente e ContaEspecial que herdam da ContaBancaria",
                " - A ContaCorrente possui um atributo TaxaDeOperacao que é descontado sempre que um saque e um depósito são feitos",
                " - A ContaEspecial possui um atributo Limite que dá crédito a mais para o correntista caso ele precise sacar mais que o saldo Neste caso, o saldo pode ficar negativo desde que não ultrapasse o limite. Contudo, isso não pode acontecer na classe ContaCorrente",
                " - Crie um interface Imprimivel que declara um método MostrarDados, implemente em ambas as contas e imprima os dados em cada uma",
                " - Via console, abra 2 contas de cada tipo e execute as operações");

            ConsoleHelper.PressioneEnter();

            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_3", "ContaBancaria");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_3", "ContaCorrente");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_3", "ContaEspecial");
            ConsoleHelper.VideInterface("MestreDosCodigos.UtilizandoPOO.Exercicio_3", "Imprimivel");
            Console.WriteLine();
        }
    }
}
