using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_2
{
    public class Pessoa
    {
        private string nome;
        private DateTime dataDeNascimento;
        private decimal altura;

        public string ObterNome() => nome;
        public void AlterarNome(string novoNome) => nome = novoNome;

        public DateTime ObterDataDeNascimento() => dataDeNascimento;
        public void AlterarDataDeNascimento(DateTime novaDataDeNascimento) => dataDeNascimento = novaDataDeNascimento;

        public decimal ObterAltura() => altura;
        public void AlterarAltura(decimal novaAltura) => altura = novaAltura;

        public int ObterIdade() => new DateTime((DateTime.Today - dataDeNascimento).Ticks).Year - 1;

        public override string ToString()
            => $"Nome: {nome} | Data de Nascimento: {dataDeNascimento.ToShortDateString()} ({ObterIdade()} anos) | Altura: {altura}";
    }
}
