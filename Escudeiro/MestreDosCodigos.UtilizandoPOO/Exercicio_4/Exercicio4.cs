using MestreDosCodigos.TrabalhandoNoConsole;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_4
{
    public class Exercicio4
    {
        public Exercicio4()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 4");

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
    }
}
