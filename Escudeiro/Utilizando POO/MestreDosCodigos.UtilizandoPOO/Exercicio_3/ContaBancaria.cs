using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_3
{
    public abstract class ContaBancaria : Imprimivel
    {
        public string NumeroDaConta { get; }
        public double Saldo { get; protected set; }

        public ContaBancaria()
        {
            NumeroDaConta = DateTime.Now.ToString("HHmmssfff");
            Saldo = 0d;
        }

        protected abstract bool HaSaldoSuficienteParaSaque(double quantia);

        public virtual void Sacar(double quantia)
        {
            Console.WriteLine(this.GetType().Name + ":SAQUE | " + quantia);

            var haSaldoSuficiente = HaSaldoSuficienteParaSaque(quantia);
            if (!haSaldoSuficiente)
            {
                Console.WriteLine("!! Não há saldo suficiente para saque !!");
                return;
            }

            Saldo -= quantia;
        }

        public virtual void Depositar(double quantia)
        {
            Console.WriteLine(this.GetType().Name + ":DEPÓSITO | " + quantia);

            if (quantia <= 0d)
            {
                Console.WriteLine("!! Não é possível depositar valores menores que 0,00 R$ !!");
                return;
            }

            Saldo += quantia;
        }

        public virtual void MostrarDados()
        { 
            Console.WriteLine("------ EXTRATO " + this.GetType().Name + " ------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Conta : " + NumeroDaConta);
            Console.WriteLine("Saldo : " + Saldo);
        }
    }
}
