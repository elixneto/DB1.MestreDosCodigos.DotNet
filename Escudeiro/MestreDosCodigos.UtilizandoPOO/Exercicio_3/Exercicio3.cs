using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_3
{
    public class Exercicio3
    {
        ContaBancaria ContaCorrente = new ContaCorrente(taxaDeOperacao: 0.15);
        ContaBancaria ContaEspecial = new ContaEspecial(limite: 1500);

        public Exercicio3()
        {
            Extrato();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******** Operações *****");

            ContaCorrente.Depositar(500);
            ContaCorrente.Sacar(400);
            ContaCorrente.Sacar(50);

            ContaEspecial.Sacar(320);
            ContaEspecial.Sacar(1159);
            ContaEspecial.Depositar(52.67);
            ContaEspecial.Sacar(1);

            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine();

            Extrato();
        }

        private void Extrato()
        {
            ContaCorrente.MostrarDados();
            ContaEspecial.MostrarDados();
        }
    }
}
