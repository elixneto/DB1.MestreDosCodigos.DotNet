using System.Collections;
using System.Collections.Generic;

namespace MestreDosCodigos.TrabalhandoCom.NUNIT._Doubles
{
    public class SomaComCalculadoraSimplesStub : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return Teste(10, 20, 30);
            yield return Teste(-5, 15, 10);
            yield return Teste(15, -5, 10);
            yield return Teste(15.35, -5.72, (15.35 - 5.72));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private object[] Teste(double a, double b, double resultadoEsperado)
            => new object[] { a, b, resultadoEsperado };
    }
}
