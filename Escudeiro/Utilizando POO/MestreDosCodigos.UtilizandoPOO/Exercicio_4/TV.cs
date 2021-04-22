namespace MestreDosCodigos.UtilizandoPOO.Exercicio_4
{
    interface TV
    {
        int Canal { get; }
        int Volume { get; }

        void AumentarVolume();
        void DiminuirVolume();
        void AumentarCanal();
        void DiminuirCanal();
        void IrParaCanal(int canal);
    }
}
