namespace MestreDosCodigos.TrabalhandoCom.NUNIT._Doubles
{
    public class SaqueDeContaEspecialFixture
    {
        public static object[] Argumentos = {
            new object[] { 150d, 500d, 150d, 0d, 500d },
            new object[] { 150d, 500d, 149d, 1d, 500d },
            new object[] {150d, 500d, 160d, 0d, 490d }
        };
    }
}
