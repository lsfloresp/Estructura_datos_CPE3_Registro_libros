using System;

Biblioteca biblioteca = new Biblioteca();

int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("          SISTEMA DE BIBLIOTECA");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1. Registrar libro");
    Console.WriteLine("2. Mostrar libros");
    Console.WriteLine("3. Salir");
    Console.WriteLine("----------------------------------------");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Libro nuevoLibro = new Libro();

            Console.Write("Ingrese el código del libro: ");
            nuevoLibro.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el título del libro: ");
            nuevoLibro.Titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            nuevoLibro.Autor = Console.ReadLine();

            Console.Write("Ingrese la categoría del libro: ");
            nuevoLibro.Categoria = Console.ReadLine();

            Console.Write("Ingrese el número de ejemplares: ");
            nuevoLibro.Ejemplares = int.Parse(Console.ReadLine());

            biblioteca.RegistrarLibro(nuevoLibro);

            break;

        case 2:

            biblioteca.MostrarLibros();

            break;

        case 3:

            Console.WriteLine("Saliendo del sistema...");

            break;

        default:

            Console.WriteLine("Opción no válida.");

            break;
    }

} while (opcion != 3);