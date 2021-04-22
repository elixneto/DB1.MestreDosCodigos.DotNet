namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_4
{
    public class Aluno
    {
        public const int QuantidadeDeNotas = 5;

        public string Nome { get; }
        public decimal[] Notas { get; } = new decimal[QuantidadeDeNotas];

        public Aluno(string nome)
        {
            Nome = nome;
        }
    }
}
