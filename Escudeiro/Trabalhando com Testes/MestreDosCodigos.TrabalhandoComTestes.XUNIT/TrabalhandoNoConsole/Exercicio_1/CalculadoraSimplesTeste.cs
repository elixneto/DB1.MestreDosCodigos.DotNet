using MestreDosCodigos.TrabalhandoComTestes.XUNIT._Doubles;
using MestreDosCodigos.TrabalhandoNoConsole.Exercicio_1;
using System;
using System.Collections.Generic;
using Xunit;

namespace MestreDosCodigos.TrabalhandoComTestes.XUNIT.TrabalhandoNoConsole.Exercicio_1
{
    public class CalculadoraSimplesTeste
    {
        [Fact]
        public void Deve_multiplicar_dois_numeros()
        {
            var multiplicaaoEsperada = 157.5;
            var calculadora = new CalculadoraSimples(5.25, 30);

            var multiplicacao = calculadora.Multiplicar();

            Assert.Equal(multiplicaaoEsperada, multiplicacao);
        }

        [Theory]
        [ClassData(typeof(SomaComCalculadoraSimplesStub))]
        public void Deve_somar_corretamente_com_classdata(double a, double b, double resultadoEsperado)
        {
            var calculadora = new CalculadoraSimples(a, b);

            var soma = calculadora.Somar();

            Assert.Equal(resultadoEsperado, soma);
        }

        [Theory]
        [MemberData(nameof(SubtracaoComCalculadoraSimplesStub))]
        public void Deve_subtrair_corretamente_com_memberdata(double a, double b, double resultadoEsperado)
        {
            var calculadora = new CalculadoraSimples(a, b);

            var soma = calculadora.Subtrair();

            Assert.Equal(resultadoEsperado, soma);
        }

        [Fact]
        public void Deve_dividir_corretamente()
        {
            var divisaoEsperada = (67d / 89d);

            var divisao = new CalculadoraSimples(89, 67).Dividir();

            Assert.Equal(divisaoEsperada, divisao);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(13.976)]
        [InlineData(0)]
        [InlineData(-34.56)]
        public void Deve_lancar_excecao_quando_dividir_por_zero(double b)
        {
            var calculadora = new CalculadoraSimples(0, b);

            void divisao() => calculadora.Dividir();

            Assert.Throws<Exception>(divisao);
        }



        public static IEnumerable<object[]> SubtracaoComCalculadoraSimplesStub()
            => new List<object[]>
            {
                new object[]{ 20, 30, -10 },
                new object[]{ 30, 20, 10 },
                new object[]{ -20, 6.75, -26.75 },
            };

    }
}
