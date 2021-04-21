using System;
using System.Collections;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces
{

    public class Enumerador : IEnumerator
    {
        private int PosicaoAtual = -1;

        public MinhaClasse[] Enumeraveis;
        public object Current => Enumeraveis[PosicaoAtual];

        public Enumerador(MinhaClasse[] enumeraveis)
        {
            Enumeraveis = enumeraveis;
        }

        public bool MoveNext()
        {
            if(++PosicaoAtual < Enumeraveis.Length)
            {
                Console.WriteLine("Next() do meu enumerador custom: " + ((MinhaClasse)Current).Nome);
                return true;
            }

            return false;
        }

        public void Reset() => PosicaoAtual = -1;
    }
}
