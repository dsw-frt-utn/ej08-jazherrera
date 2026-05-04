namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema4 problema4 = new Problema4();

            // Caso 1: todas con valor válido
            Console.WriteLine(problema4.CalcularPromedio(8, 6, 10));    // 8

            // Caso 2: una nota null
            Console.WriteLine(problema4.CalcularPromedio(8, null, 10)); // 9

            // Caso 3: todas null
            Console.WriteLine(problema4.CalcularPromedio(null, null, null)); // 0

            // Caso 4: una nota fuera de rango
            Console.WriteLine(problema4.CalcularPromedio(8, -1, 10));   // 9

            // Caso 5: todas fuera de rango
            Console.WriteLine(problema4.CalcularPromedio(-1, 11, -5));  // 0
        }
    }
}
