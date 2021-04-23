using MestreDosCodigos.TrabalhandoCom.NUNIT._Doubles;
using MestreDosCodigos.UtilizandoPOO.Exercicio_3;
using NUnit.Framework;

namespace MestreDosCodigos.TrabalhandoCom.NUNIT.UtilizandoPOO.Exercicio_3
{
    [TestFixtureSource(typeof(SaqueDeContaEspecialFixture), nameof(SaqueDeContaEspecialFixture.Argumentos))]
    public class SaqueDeContaEspecialTeste
    {
        public double _saldo;
        public double _limite;
        public double _valorParaSaque;
        public double _saldoAposSaque;
        public double _limiteAposSaque;

        public SaqueDeContaEspecialTeste(double saldo, double limite, double valorParaSaque, double saldoAposSaque, double limiteAposSaque)
        {
            _saldo = saldo;
            _limite = limite;
            _valorParaSaque = valorParaSaque;
            _saldoAposSaque = saldoAposSaque;
            _limiteAposSaque = limiteAposSaque;
        }


        [Test]
        public void Deve_manter_saldo_atualizado_e_limite_quando_houver_operacao_de_saque()
        {
            var contaEspecial = new ContaEspecial(_limite);
            contaEspecial.Depositar(_saldo);

            contaEspecial.Sacar(_valorParaSaque);

            Assert.AreEqual(_saldoAposSaque, contaEspecial.Saldo);
            Assert.AreEqual(_limiteAposSaque, contaEspecial.Limite);
        }
    }
}
