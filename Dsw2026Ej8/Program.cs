namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 problema5 = new Problema5();

            RetailSale retail = new RetailSale(1000);
            WholesaleSale wholesale = new WholesaleSale(1000);

            Console.WriteLine("RetailSale: " + problema5.ObtenerImporteFinal(retail));
            Console.WriteLine("WholesaleSale: " + problema5.ObtenerImporteFinal(wholesale));
        }
    }
}
