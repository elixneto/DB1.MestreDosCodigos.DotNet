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
            try
            {
                base.Sacar(quantia);

                DescontarTaxaDeOperacao();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void Depositar(double quantia)
        {
            try
            {
                base.Depositar(quantia);

                DescontarTaxaDeOperacao();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void MostrarDados()
        {
            base.MostrarDados();

            Console.WriteLine("Tx Op : " + TaxaDeOperacao);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        public void DescontarTaxaDeOperacao() => Saldo -= TaxaDeOperacao;

        protected override bool HaSaldoSuficienteParaSaque(double quantia)
            => (Saldo - quantia) >= 0;
    }
}
