namespace MestreDosCodigos.UtilizandoPOO.Exercicio_4
{
    class Televisao : TV
    {
        public const int VOLUME_MINIMO = 0;
        public const int VOLUME_MAXIMO = 100;
        public const int CANAL_MINIMO = 1;
        public const int CANAL_MAXIMO = 999;

        public int Volume { get; private set; }
        public int Canal { get; private set; } = 1;

        public void AumentarVolume()
        {
            if (Volume == VOLUME_MAXIMO)
            {
                return;
            }

            Volume++;
        }

        public void DiminuirVolume()
        {
            if (Volume == VOLUME_MINIMO)
            {
                return;
            }

            Volume--;
        }

        public void AumentarCanal()
        {
            if (Canal == CANAL_MAXIMO)
            {
                return;
            }

            Canal++;
        }

        public void DiminuirCanal()
        {
            if (Canal == CANAL_MINIMO)
            {
                return;
            }
            
            Canal--;
        }

        public void IrParaCanal(int canal)
        {
            if (canal < CANAL_MINIMO || canal > CANAL_MAXIMO)
            {
                return;
            }

            Canal = canal;
        }
    }
}
