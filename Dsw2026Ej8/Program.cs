namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product producto = new Product("Laptop");

            // Ver descripción antes
            Console.WriteLine("Descripción antes: " + producto.GetDescription());

            // Llamar al método
            Problema3 problema3 = new Problema3();
            string resultado = problema3.CompararCopias(5, producto);

            // Ver resultado
            Console.WriteLine("Resultado: " + resultado);

            // Ver descripción después (para confirmar que se modificó)
            Console.WriteLine("Descripción después: " + producto.GetDescription());
        }
    }
}
