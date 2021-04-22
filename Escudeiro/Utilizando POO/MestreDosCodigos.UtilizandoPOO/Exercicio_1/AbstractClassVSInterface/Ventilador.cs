using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface
{
    public class Ventilador : Ligavel
    {
        public void Desligar()
        {
            Console.WriteLine("Ventilador: desligar");
        }

        public void Ligar()
        {
            Console.WriteLine("Ventilador: ligar");
        }
    }
}
