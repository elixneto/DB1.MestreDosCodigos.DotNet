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
            if (quantia <= 0d)
            {
                throw new Exception("!! Não é possível sacar valores menores que 0,00 R$ !!");
            }

            var haSaldoSuficiente = HaSaldoSuficienteParaSaque(quantia);
            if (!haSaldoSuficiente)
            {
                throw new Exception("!! Não há saldo suficiente para saque !!");
            }

            Saldo -= quantia;
            Console.WriteLine(this.GetType().Name + ":SAQUE | " + quantia);
        }

        public virtual void Depositar(double quantia)
        {
            if (quantia <= 0d)
            {
                throw new Exception("!! Não é possível depositar valores menores que 0,00 R$ !!");
            }

            Saldo += quantia;
            Console.WriteLine(this.GetType().Name + ":DEPÓSITO | " + quantia);
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
