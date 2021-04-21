using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface
{
    public class Lampada : Ligavel
    {
        public void Desligar()
        {
            Console.WriteLine("Lampada: desligar");
        }

        public void Ligar()
        {
            Console.WriteLine("Lampada: ligar");
        }
    }
}
