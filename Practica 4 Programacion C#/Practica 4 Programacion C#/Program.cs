namespace Programacion_Pratica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];

            Console.WriteLine("Registro de Temperaturas");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                bool entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write($"Ingrese la temperatura del dia {i + 1}: ");
                    var input = Console.ReadLine();

                    if (double.TryParse(input, out double temp))
                    {
                        temperaturas[i] = temp;
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Dato invalido! Por favor, ingresa un numero positivo o negativo valido!");
                    }
                }
            }

            double temperaturaAlta = temperaturas.Max();
            double temperaturaBaja = temperaturas.Min();
            double promedioSemanal = temperaturas.Average();

            int diasEncima = 0;
            int diasDebajo = 0;

            foreach (double temp in temperaturas)
            {
                if (temp > promedioSemanal)
                {
                    diasEncima++;
                }
                else if (temp < promedioSemanal)
                {
                    diasDebajo++;
                }
            }

            Console.WriteLine("\nRegistro de la Semana");
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine($"Dia {i + 1}: {temperaturas[i]:F1}°C");
            }

            Console.WriteLine($"Temperatura mas alta: {temperaturaAlta:F1}°C");
            Console.WriteLine($"Temperatura mas baja: {temperaturaBaja:F1}°C");
            Console.WriteLine($"Promedio semanal: {promedioSemanal:F2}°C");
            Console.WriteLine($"Dias por encima del promedio: {diasEncima}");
            Console.WriteLine($"Dias por debajo del promedio: {diasDebajo}");

            Console.WriteLine("\nPresione cualquier tecla para salir!");
            Console.ReadKey();
        }
    }
}