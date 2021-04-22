using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_4
{
    class ControleRemoto
    {
        private readonly TV _tv;

        public ControleRemoto(TV tv)
        {
            _tv = tv;
        }

        public void VolumeMais()
        {
            Console.WriteLine("VOLUME +");
            _tv.AumentarVolume();
        }
        public void VolumeMenos()
        {
            Console.WriteLine("VOLUME -");
            _tv.DiminuirVolume();
        }

        public void CanalMais()
        {
            Console.WriteLine("CANAL +");
            _tv.AumentarCanal();
        }

        public void CanalMenos()
        {
            Console.WriteLine("CANAL -");
            _tv.DiminuirCanal();
        }

        public void Canal(int canal)
        {
            Console.WriteLine("CANAL " + canal);
            _tv.IrParaCanal(canal);
        }

        public void MostrarDadosDaTV()
        {
            Console.WriteLine();
            Console.WriteLine($"TV | Canal: {_tv.Canal} | Volume: {_tv.Volume}");
            Console.WriteLine();
        }
    }
}
