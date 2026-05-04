namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();
            Console.WriteLine(
                helper.ObtenerEtiquetaProducto(10, "Cuaderno", 2500)
            );
        }
    }
}
