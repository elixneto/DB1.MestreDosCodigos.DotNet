using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces
{
    public class Descartavel : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("método Descartavel.Dispose() invocado");
        }
    }
}
