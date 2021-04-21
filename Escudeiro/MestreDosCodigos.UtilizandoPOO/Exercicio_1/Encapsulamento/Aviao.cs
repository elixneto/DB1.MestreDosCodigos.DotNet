using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Encapsulamento
{
    public sealed class Aviao
    {
        private readonly string LinhaAerea;
        private int AcentosOcupados;

        public string Piloto { get; }
        public string Copiloto { get; private set; }
        public string Cor { get; set; }

        public Aviao(string linhaAerea, int acentosOcupados)
        {
            LinhaAerea = linhaAerea;
            AcentosOcupados = acentosOcupados;
            Piloto = "Piloto Default da Silva";
            Copiloto = "Copiloto Default de Souza";
            Cor = "Default";
        }

        public void Decolar()
        {
            Console.WriteLine("PUBLIC início da decolagem ...");

            RecolherTremDePouso();
        }

        public void Pousar()
        {
            Console.WriteLine("PUBLIC início do pouso ...");

            Copiloto = "Outro Copiloto";

            AbrirTremDePouso();

            AcentosOcupados = 0;
        }

        private void AbrirTremDePouso()
        {
            Console.WriteLine("** PRIVATE trem de pouso aberto");
        }

        private void RecolherTremDePouso()
        {
            Console.WriteLine("** PRIVATE trem de pouso recolhido");
        }

        public override string ToString()
            => $"Aviao | Linha Aérea: {LinhaAerea} | Acentos: {AcentosOcupados} | Piloto: {Piloto} | Copiloto: {Copiloto} | Cor: {Cor}";
    }
}
