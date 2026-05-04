namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema2 p2 = new Problema2();

            string resultado = p2.CrearResumenVenta(
                100,
                "Lapicera",
                3,
                150
            );

            Console.WriteLine(resultado);
        }
    }
}
