using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_3
{
    public class ContaEspecial : ContaBancaria
    {
        public double Limite { get; private set; }

        public ContaEspecial(double limite)
            : base()
        {
            Limite = limite;
        }

        public override void Sacar(double quantia)
        {
            base.Sacar(quantia);

            if(Saldo < 0d)
            {
                Limite += Saldo;
                Saldo = 0d;
            }
        }

        public override void MostrarDados()
        {
            base.MostrarDados();

            Console.WriteLine("Limite: " + Limite);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        protected override bool HaSaldoSuficienteParaSaque(double quantia)
            => (Saldo + Limite - quantia) >= 0;
    }
}
