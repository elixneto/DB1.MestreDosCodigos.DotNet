using System.Collections;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces
{
    public class ListaDeEnumeravel : IEnumerable
    {
        private MinhaClasse[] Enumeraveis;

        public int Tamanho => Enumeraveis.Length;

        public Enumerador GetEnumerator() => new Enumerador(Enumeraveis);

        public void Adicionar(MinhaClasse[] enumeraveis) => Enumeraveis = enumeraveis;


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
