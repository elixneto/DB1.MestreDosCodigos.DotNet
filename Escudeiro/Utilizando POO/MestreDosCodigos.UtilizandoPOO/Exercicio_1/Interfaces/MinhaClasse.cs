using System;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces
{
    public class MinhaClasse : IComparable, ICloneable
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public MinhaClasse Referencia { get; set; }

        public MinhaClasse(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }

        public int CompareTo(object obj)
        {
            if (obj is not MinhaClasse)
            {
                return 1;
            }

            return ((MinhaClasse)obj).Nome.Length < Nome.Length ? 1 : -1;
        }

        public object Clone()
        {
            if (Nome == "Memberwise")
                return this.MemberwiseClone();

            return new MinhaClasse(id: 999, Nome);
        }

        public override string ToString() => $"ID: {ID} | Nome: {Nome} | Referencia: {Referencia?.ID}-{Referencia?.Nome}";
    }
}
