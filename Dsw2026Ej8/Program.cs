namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema6 problema6 = new Problema6();

            Console.WriteLine(problema6.NormalizarCodigoProducto(" ab 123 x ")); // AB-123-X
            Console.WriteLine(problema6.NormalizarCodigoProducto("  hola mundo  ")); // HOLA-MUNDO
            Console.WriteLine(problema6.NormalizarCodigoProducto(null));           // SIN-CODIGO
            Console.WriteLine(problema6.NormalizarCodigoProducto("xyz"));          // XYZ

        }
    }
}
