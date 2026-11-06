namespace SistemaTienda
{
    class Cliente
    {
        private string? nombre;

        private string? correo;

        private string? telefono;

        public void Solicitar_Datos()
        {
            Console.WriteLine("Registro del Cliente");
            nombre = Leer_Nombre();
            correo = Leer_Correo();
            telefono = Leer_Telefono();
            Console.WriteLine();
        }

        public void Imprimir_Informacion()
        {
            Console.WriteLine("Cliente");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Correo: {correo}");
            Console.WriteLine($"Telefono: {telefono}");
        }
        private string? Leer_Nombre()
        {
            string input;
            do
            {
                Console.Write("Nombre: ");
                input = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Necesitas poner un nombre! no puede quedar vacia esta ranura");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        private string? Leer_Correo()
        {
            string input;
            do
            {
                Console.Write("Correo: ");
                input = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(input) || !input.Contains("@"))
                {
                    Console.WriteLine("Correo inválido! Asegurate de incluir '@' e intentalo de nuevo");
                }
            } while (string.IsNullOrWhiteSpace(input) || !input.Contains("@"));
            return input;
        }

        private string? Leer_Telefono()
        {
            string input;
            do
            {
                Console.Write("Telefono: ");
                input = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ingresa un numero de telefono! esta ranura no puede quedar vacia");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
    }
    class Producto
    {
        private string? nombre;
        private double precio;

        private int cantidad;

        public void Solicitar_Datos()
        {
            Console.WriteLine("Registro del Producto");
            nombre = Leer_Nombre();
            precio = Leer_Precio();
            cantidad = Leer_Cantidad();
            Console.WriteLine();
        }

        public double Calcular_Subtotal()
        {
            return precio * cantidad;
        }

        public void Imprimir_Informacion()
        {
            Console.WriteLine("Producto");
            Console.WriteLine($"Producto: {nombre}");
            Console.WriteLine($"Precio: ${precio:N2}");
            Console.WriteLine($"Cantidad: {cantidad}");
        }
        private string Leer_Nombre()
        {
            string input;
            do
            {
                Console.Write("- Producto: ");
                input = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ingresa un nombre para el producto! el nombre del producto no puede estar vacio");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        private double Leer_Precio()
        {
            double val;
            string input;
            do
            {
                Console.Write("- Precio: $");
                input = Console.ReadLine()!;
                if (!double.TryParse(input, out val) || val <= 0)
                {
                    Console.WriteLine("El precio debe ser un numero mayor a 0 o valido");
                }
            } while (!double.TryParse(input, out val) || val <= 0);
            return val;
        }

        private int Leer_Cantidad()
        {
            int val;
            string input;
            do
            {
                Console.Write("Cantidad: ");
                input = Console.ReadLine()!;
                if (!int.TryParse(input, out val) || val <= 0)
                {
                    Console.WriteLine("La cantidad debe ser un numero mayor a 0");
                }
            } while (!int.TryParse(input, out val) || val <= 0);
            return val;
        }
    }
    class Venta
    {
        private Cliente cliente = null!;
        private Producto producto = null!;
        private double subtotal;
        private double descuento;
        private double total;

        public void Registrar_Venta(Cliente clienteObj, Producto productoObj)
        {
            cliente = clienteObj;
            producto = productoObj;

            subtotal = producto.Calcular_Subtotal();
            descuento = Calcular_Descuento();
            total = Calcular_Total();
        }

        private double Calcular_Descuento()
        {
            double porcentaje = 0.0;

            if (subtotal >= 3000)
            {
                porcentaje = 0.10; // 10%
            }
            else if (subtotal >= 1000)
            {
                porcentaje = 0.05; // 5%
            }
            // Menor a $1,000 queda en 0% (sin descuento)[cite: 4, 5]

            return subtotal * porcentaje;
        }

        private double Calcular_Total()
        {
            return subtotal - descuento;
        }

        public void Imprimir_Ticket()
        {
            Console.WriteLine("TICKET DE COMPRA");
            cliente.Imprimir_Informacion();
            Console.WriteLine();
            producto.Imprimir_Informacion();

            double porcentajeMostrado = 0;
            if (subtotal >= 3000) porcentajeMostrado = 10;
            else if (subtotal >= 1000) porcentajeMostrado = 5;

            Console.WriteLine($"- Subtotal: ${subtotal:N2}");
            Console.WriteLine($"- Descuento: {porcentajeMostrado}%");
            Console.WriteLine($"Total descuento: ${descuento:N2}");
            Console.WriteLine($"TOTAL A PAGAR: ${total:N2}");
            Console.WriteLine("==========================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE TIENDA\n");

            Cliente cliente = new Cliente();
            Producto producto = new Producto();
            Venta venta = new Venta();

            cliente.Solicitar_Datos();
            producto.Solicitar_Datos();

            venta.Registrar_Venta(cliente, producto);

            venta.Imprimir_Ticket();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}