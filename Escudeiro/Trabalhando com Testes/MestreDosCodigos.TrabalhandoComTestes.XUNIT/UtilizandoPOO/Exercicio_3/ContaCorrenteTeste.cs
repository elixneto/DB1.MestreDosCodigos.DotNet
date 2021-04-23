using MestreDosCodigos.UtilizandoPOO.Exercicio_3;
using Xunit;

namespace MestreDosCodigos.TrabalhandoComTestes.XUNIT.UtilizandoPOO.Exercicio_3
{
    public class ContaCorrenteTeste
    {
        private readonly ContaCorrente _contaCorrente;

        public ContaCorrenteTeste()
        {
            _contaCorrente = new ContaCorrente(taxaDeOperacao: 0.01);
        }

        [Fact]
        public void Deve_ser_classe_concreta_de_ContaBancaria_e_herdar_de_Imprimivel()
        {
            var ehContaBancaria = typeof(ContaBancaria).IsAssignableFrom(typeof(ContaCorrente));
            var ehImprimivel = typeof(Imprimivel).IsAssignableFrom(typeof(ContaCorrente));

            Assert.True(ehContaBancaria);
            Assert.True(ehImprimivel);
        }

        [Fact]
        public void Deve_descontar_a_taxa_de_operacao_quando_houver_deposito()
        {
            var saldoEsperado = 500d;
            
            _contaCorrente.Depositar(500.01);

            Assert.Equal(saldoEsperado, _contaCorrente.Saldo);
        }

        [Fact]
        public void Deve_descontar_a_taxa_de_operacao_quando_houver_saque_com_saldo_disponivel()
        {
            var saldoEsperado = 399.99d;
            _contaCorrente.Depositar(500.01);

            _contaCorrente.Sacar(100d);

            Assert.Equal(saldoEsperado, _contaCorrente.Saldo);
        }

        [Fact]
        public void Nao_deve_permitir_saque_com_saldo_indisponivel()
        {
            var saldoAnterior = _contaCorrente.Saldo;

            _contaCorrente.Sacar(0.1);

            Assert.Equal(saldoAnterior, _contaCorrente.Saldo);
        }

        [Fact]
        public void Nao_deve_permitir_deposito_com_valor_igual_zero()
        {
            var saldoAnterior = _contaCorrente.Saldo;

            _contaCorrente.Depositar(0);

            Assert.Equal(saldoAnterior, _contaCorrente.Saldo);
        }
    }
}
