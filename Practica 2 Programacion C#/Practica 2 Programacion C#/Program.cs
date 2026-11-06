namespace Practica_2_Programacion_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Jugaremos un juego, adivina el numero aleatorio entre 1 y 100!");

            Console.WriteLine("Tienes 5 intentos para ganar, si no lo adivinas perderas!");
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 5;

            while (intentos > 0)
            {
                Console.Write("Introduce el numero que piensas: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int suposicion))
                {
                    if (suposicion == numeroAleatorio)
                    {
                        Console.WriteLine("Bien! Adivinaste el numero!");
                        break;
                    }
                    else if (suposicion < numeroAleatorio)
                    {
                        Console.WriteLine("El numero es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El numero es menor");
                    }
                    intentos--;
                    Console.WriteLine($"Te quedan {intentos} intentos");
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número valido");
                }
            }

            if (intentos == 0)
            {
                Console.WriteLine($"Has perdido... El número era {numeroAleatorio}");

            }
            }
        }
    }
