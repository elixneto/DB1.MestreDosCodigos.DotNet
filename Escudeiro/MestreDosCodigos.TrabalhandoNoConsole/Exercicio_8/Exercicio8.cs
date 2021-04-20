using System;
using System.Collections.Generic;

namespace MestreDosCodigos.TrabalhandoNoConsole.Exercicio_8
{
    public class Exercicio8
    {
        List<decimal> ListaDeDecimais;

        public Exercicio8()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 8");

            var quantidadeDeDecimais = ConsoleHelper.LerInteiro("Informe a quantidade de decimais:");

            ListaDeDecimais = new List<decimal>(quantidadeDeDecimais);

            Console.WriteLine($"Informe os {quantidadeDeDecimais} decimais:");

            int i = 0;
            while (i < quantidadeDeDecimais)
            {
                var numero = ConsoleHelper.LerDecimal();
                ListaDeDecimais.Add(numero);

                i++;
            }

            OrdenarCrescente();
            Imprimir();

            OrdenarDecrescente();
            Imprimir();
        }

        private void OrdenarCrescente()
        {
            // Por padrão ordena crescente
            // ListaDeDecimais.Sort();

            ListaDeDecimais.Sort(ComparacaoCrescente);
        }

        private void OrdenarDecrescente()
        {
            // Ordena ao contrário (se executar o .Sort() antes do .Reverse()
            // a lista fica ordenada decrescente)
            // ListaDeDecimais.Reverse();

            ListaDeDecimais.Sort(ComparacaoDecrescente);
        }

        private void Imprimir()
        {
            Console.WriteLine("----------");
            foreach (var numero in ListaDeDecimais)
            {
                Console.WriteLine(numero);
            }
        }

        private int ComparacaoCrescente(decimal x, decimal y)
        {
            if (x == y)
                return 0;

            return x > y ? 1 : -1;
        }

        private int ComparacaoDecrescente(decimal x, decimal y)
        {
            if (x == y)
                return 0;

            return x > y ? -1 : 1;
        }
    }
}
