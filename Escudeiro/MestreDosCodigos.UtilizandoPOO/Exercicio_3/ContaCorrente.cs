using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_3
{
    public class ContaCorrente : ContaBancaria
    {
        public double TaxaDeOperacao { get; }

        public ContaCorrente(double taxaDeOperacao)
            : base()
        {
            TaxaDeOperacao = taxaDeOperacao;
        }

        public override void Sacar(double quantia)
        {
            base.Sacar(quantia);

            DescontarTaxaDeOperacao();
        }

        public override void Depositar(double quantia)
        {
            base.Depositar(quantia);

            DescontarTaxaDeOperacao();
        }

        public override void MostrarDados()
        {
            base.MostrarDados();

            Console.WriteLine("Tx Op : " + TaxaDeOperacao);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        protected override bool HaSaldoSuficienteParaSaque(double quantia)
            => (Saldo - quantia) >= 0;

        private void DescontarTaxaDeOperacao() => Saldo -= TaxaDeOperacao;
    }
}
