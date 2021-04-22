using MestreDosCodigos.TrabalhandoNoConsole;
using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_4
{
    public class Exercicio4
    {
        public Exercicio4()
        {
            MostrarTexto();

            {
                var controle = new ControleRemoto(new Televisao());
                controle.MostrarDadosDaTV();

                controle.Canal(900);
                controle.VolumeMais();
                controle.VolumeMais();
                controle.VolumeMais();
                controle.VolumeMais();
                controle.VolumeMenos();
                controle.CanalMenos();
                controle.CanalMenos();
                controle.CanalMenos();
                controle.CanalMenos();
                controle.CanalMais();

                controle.MostrarDadosDaTV();
            }

            Console.WriteLine();
            ConsoleHelper.VideChamada("MestreDosCodigos.UtilizandoPOO.Exercicio_4", "Exercicio4", 12);
        }


        private void MostrarTexto()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 4",
                "Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle permite:",
                " - Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez",
                " - Aumentar ou diminuir o número do canal em uma unidade",
                " - Trocar para um canal indicado",
                " - Consultar o valor do volume de som e o canal selecionado",
                " - Imprima os dados via console");

            ConsoleHelper.PressioneEnter();

            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_4", "Televisao");
            ConsoleHelper.VideClasse("MestreDosCodigos.UtilizandoPOO.Exercicio_4", "ControleRemoto");
            ConsoleHelper.VideInterface("MestreDosCodigos.UtilizandoPOO.Exercicio_4", "TV");
            Console.WriteLine();
        }
    }
}
