using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores
{
    public abstract class Computador : Ligavel
    {
        public string Nome { get; }

        public Computador(string nome)
        {
            Nome = nome;
        }

        public void Desligar()
        {
            Console.WriteLine("ComputadorBASE: desligar");
        }

        public virtual void Ligar()
        {
            Console.WriteLine("ComputadorBASE: ligar");
        }

        public abstract void PressionarTecla(char tecla);
    }
}
