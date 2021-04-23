using MestreDosCodigos.TrabalhandoCom.NUNIT._Doubles;
using MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MestreDosCodigos.TrabalhandoCom.NUNIT.TrabalhandoNoConsole.Exercicio_1
{
    public class CalculadoraSimplesTeste
    {
        [Test]
        public void Deve_multiplicar_dois_numeros()
        {
            var multiplicaaoEsperada = 157.5;
            var calculadora = new CalculadoraSimples(5.25, 30);

            var multiplicacao = calculadora.Multiplicar();

            Assert.AreEqual(multiplicaaoEsperada, multiplicacao);
        }

        [Test]
        [TestCaseSource(typeof(SomaComCalculadoraSimplesStub))]
        public void Deve_somar_corretamente_com_testcasesource(double a, double b, double resultadoEsperado)
        {
            var calculadora = new CalculadoraSimples(a, b);

            var soma = calculadora.Somar();

            Assert.AreEqual(resultadoEsperado, soma);
        }

        [Test]
        [TestCaseSource(nameof(SubtracaoComCalculadoraSimplesStub))]
        public void Deve_subtrair_corretamente_com_testcasesource(double a, double b, double resultadoEsperado)
        {
            var calculadora = new CalculadoraSimples(a, b);

            var soma = calculadora.Subtrair();

            Assert.AreEqual(resultadoEsperado, soma);
        }

        [Test]
        public void Deve_dividir_corretamente()
        {
            var divisaoEsperada = (67d / 89d);

            var divisao = new CalculadoraSimples(89, 67).Dividir();

            Assert.AreEqual(divisaoEsperada, divisao);
        }

        [TestCase(1)]
        [TestCase(13.976)]
        [TestCase(0)]
        [TestCase(-34.56)]
        public void Deve_lancar_excecao_quando_dividir_por_zero(double b)
        {
            var calculadora = new CalculadoraSimples(0, b);

            void divisao() => calculadora.Dividir();

            Assert.Throws<Exception>(divisao);
        }


        private static IEnumerable<object[]> SubtracaoComCalculadoraSimplesStub()
            => new List<object[]>
            {
                new object[]{ 20, 30, -10 },
                new object[]{ 30, 20, 10 },
                new object[]{ -20, 6.75, -26.75 },
            };
    }
}
