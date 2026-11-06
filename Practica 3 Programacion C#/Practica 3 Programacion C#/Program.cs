namespace Practica_3_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tienda!");

            int cantidadVentas = 0;
            while (cantidadVentas <= 0)
            {
                Console.Write("Cuantas ventas fueron el dia de hoy?: ");
                string entradaCantidad = Console.ReadLine() ?? "";

                if (!int.TryParse(entradaCantidad, out cantidadVentas) || cantidadVentas <= 0)
                {
                    Console.WriteLine("Por favor, ingresa un numero que sea mayor a 0 o que sea valido");
                }
            }
            double[] ventas = new double[cantidadVentas];
            Console.WriteLine();

            for (int i = 0; i < ventas.Length; i++)
            {
                bool ventaValida = false;
                while (!ventaValida)
                {
                    Console.Write($"Venta {i + 1}: $");
                    string entradaVenta = Console.ReadLine() ?? "";

                    if (double.TryParse(entradaVenta, out double monto) && monto >= 0)
                    {
                        ventas[i] = monto;
                        ventaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida! Ingresa un numero valido!");
                    }
                }
            }

            double totalRecaudado = ventas.Sum();
            double promedioVentas = ventas.Average();

            int ventasMayoresPromedio = 0;
            foreach (double venta in ventas)
            {
                if (venta > promedioVentas)
                {
                    ventasMayoresPromedio++;
                }
            }
            Console.WriteLine("Ventas de hoy");
            Console.WriteLine($"➔ Total recaudado: ${totalRecaudado:F2}");
            Console.WriteLine($"➔ Promedio: ${promedioVentas:F2}");
            Console.WriteLine($"➔ Ventas mayores al promedio: {ventasMayoresPromedio}");

            Console.WriteLine("\nPresiona cualquier tecla para salir!");
            Console.ReadKey();
        }
    }
}
