using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores
{
    public class NotebookSAMSUNG : Computador
    {
        public NotebookSAMSUNG()
            : base("SAMSUNG")
        {
        }

        public override void PressionarTecla(char tecla)
        {
            Console.WriteLine("NotebookSAMSUNG - tecla: " + tecla);
        }

        public override void Ligar()
        {
            base.Ligar();

            Console.WriteLine("NotebookSAMSUNG - ligar: A samsung tem que limpar o disco");
        }
    }
}
