using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_2
{
    public class Exercicio2
    {
        public Exercicio2()
        {
            var pessoa = new Pessoa();

            pessoa.AlterarNome("Élix Neto");
            pessoa.AlterarDataDeNascimento(new DateTime(1993, 4, 18));
            pessoa.AlterarAltura(1.73m);

            Console.WriteLine(pessoa);
        }
    }
}
