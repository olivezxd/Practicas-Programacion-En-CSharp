using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Buenos dias, bienvenido al estacionamiento"); //Inicio del programa

        Console.WriteLine("Cuanto tiempo desea estacionarse? La estadia puede ser de 1 a 8 horas");

        Console.WriteLine("1) 1 Hora"); //Opciones de tiempo que el usuario puede elegir

        Console.WriteLine("2) 2 Horas");

        Console.WriteLine("3) 3 Horas");

        Console.WriteLine("4) 4 Horas");

        Console.WriteLine("5) 5 Horas");

        Console.WriteLine("6) 6 Horas");

        Console.WriteLine("7) 7 Horas");

        Console.WriteLine("8) 8 Horas");

        string? Opciones = Console.ReadLine(); //Para que el usuario pueda elegir la opcion que desea elegir, y se guarda en la variable Opciones

        switch (Opciones)
        {
            case "1":
                Console.WriteLine("Ha seleccionado 1 hora, serian 30$ pesos"); //Aqui tambien se ven las variedades de opciones
                Console.WriteLine("Total a pagar: 30$ pesos"); //Total a pagar
                break;
            case "2":
                Console.WriteLine("Ha seleccionado 2 horas, serian 50$ pesos");
                Console.WriteLine("Total a pagar: 50$ pesos");
                break;
            case "3":
                Console.WriteLine("Ha seleccionado 3 horas, serian 70$ pesos");
                Console.WriteLine("Total a pagar: 70$ pesos");
                break;
            case "4":
                Console.WriteLine("Ha seleccionado 4 horas, serian 90$ pesos");
                Console.WriteLine("Total a pagar: 90$ pesos");
                break;
            case "5":
                Console.WriteLine("Ha seleccionado 5 horas, serian 110$ pesos");
                Console.WriteLine("Total a pagar: 110$ pesos");
                break;
            case "6":
                Console.WriteLine("Ha seleccionado 6 horas, serian 130$ pesos");
                Console.WriteLine("Total a pagar: 130$ pesos");
                break;
            case "7":
                Console.WriteLine("Ha seleccionado 7 horas, serian 150$ pesos");
                Console.WriteLine("Total a pagar: 150$ pesos");
                break;
            case "8":
                Console.WriteLine("Ha seleccionado 8 horas, serian 170$ pesos");
                Console.WriteLine("Total a pagar: 170$ pesos");
                break;
            default:
                Console.WriteLine("Opcion no valida, por favor elija un numero del 1 al 8"); //Al ingresar algun numero que no sea del 1 al 8
                break;
        }
    }
}