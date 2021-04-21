using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores
{
    public class NotebookLENOVO : Computador
    {
        public NotebookLENOVO()
            : base("LENOVO")
        {
        }

        public override void PressionarTecla(char tecla)
        {
            Console.WriteLine("NotebookLENOVO - tecla: " + tecla);
        }
    }
}
