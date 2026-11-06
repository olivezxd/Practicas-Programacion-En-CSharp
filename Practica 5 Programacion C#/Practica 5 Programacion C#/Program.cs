using System;

using System.Collections.Generic;

using System.Linq;

namespace Practica_5_Programacion
{
    internal class Program
    {

        public class Producto
        {
            public int Id { get; set; }

            public string? Nombre { get; set; }

            public decimal Precio { get; set; }

            class Program
            {

                static List<Producto> productos = new List<Producto>();

                static int ultimoId = 1;

                static void Main(string[] args)
                {
                    int opcion;
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("Menu de Productos en CRUD");

                        Console.WriteLine("1) Crear producto");

                        Console.WriteLine("2) Listar productos");

                        Console.WriteLine("3) Actualizar producto");

                        Console.WriteLine("4) Eliminar producto");

                        Console.WriteLine("5) Salir");

                        Console.Write("Elige una opcion: ");

                        if (int.TryParse(Console.ReadLine(), out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    Crear();
                                    break;
                                case 2:
                                    Leer();
                                    break;
                                case 3:
                                    Actualizar();
                                    break;
                                case 4:
                                    Eliminar();
                                    break;
                                case 5:
                                    Console.WriteLine("Bueno, nos vemos!");
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida!");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor introduzca un numero valido!");
                        }

                        if (opcion != 5)
                        {
                            Console.WriteLine("Presiona cualquier tecla para continuar!");
                            Console.ReadKey();
                        }

                    } while (opcion != 5);
                }

                // Create

                static void Crear()
                {
                    Console.Clear();

                    Console.WriteLine("Creacion de Producto");

                    Console.Write("Nombre del producto: ");

                    string? nombre = Console.ReadLine();

                    Console.Write("Precio del producto: ");

                    if (decimal.TryParse(Console.ReadLine(), out decimal precio))
                    {
                        Producto nuevoProducto = new Producto
                        {
                            Id = ultimoId++,
                            Nombre = nombre,
                            Precio = precio
                        };

                        productos.Add(nuevoProducto);

                        Console.WriteLine("Producto creado con exito!");
                    }
                    else
                    {
                        Console.WriteLine("Precio inválido");
                    }
                }

                // Read

                static void Leer()
                {
                    Console.Clear();
                    Console.WriteLine("Lista de Productos");

                    if (productos.Count == 0)
                    {
                        Console.WriteLine("No hay productos registrados");
                        return;
                    }

                    foreach (var p in productos)
                    {
                        Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Precio: ${p.Precio:F2}");
                    }
                }

                // Update

                static void Actualizar()
                {
                    Console.Clear();
                    Console.WriteLine("Actualizacion de Producto");
                    Leer();

                    if (productos.Count == 0) return;

                    Console.Write("Introduce el ID del producto que deseas actualizar: ");

                    if (int.TryParse(Console.ReadLine(), out int id))
                    {

                        Producto producto = productos.FirstOrDefault(p => p.Id == id)!;


                        if (producto != null)
                        {
                            Console.Write("Nuevo nombre (actual: {producto.Nombre}): ");

                            string? nuevoNombre = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(nuevoNombre))
                            {
                                producto.Nombre = nuevoNombre;
                            }

                            Console.Write("Nuevo precio (actual: {producto.Precio}): ");

                            string? inputPrecio = Console.ReadLine();

                            if (decimal.TryParse(inputPrecio, out decimal nuevoPrecio))
                            {
                                producto.Precio = nuevoPrecio;
                            }

                            Console.WriteLine("Producto actualizado");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro un producto con ese ID!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID invalido, introduce un ID valido!");
                    }
                }

                // Delete

                static void Eliminar()
                {
                    Console.Clear();

                    Console.WriteLine("Eliminacion de Producto");

                    Leer();

                    if (productos.Count == 0) return;

                    Console.Write("Introduce el ID del producto que desee eliminar: ");

                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        Producto producto = productos.FirstOrDefault(p => p.Id == id)!;

                        if (producto != null)
                        {
                            productos.Remove(producto);
                            Console.WriteLine("Producto eliminado correctamente!");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró un producto con ese ID! busca otro ID e intentalo de nuevo");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID invalido! introduce un ID valido");
                    }
                }
            }
        }
    }
}
