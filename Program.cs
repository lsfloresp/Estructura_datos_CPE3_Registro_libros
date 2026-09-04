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
    Console.WriteLine("3. Buscar libro por código");
    Console.WriteLine("4. Modificar ejemplares");
    Console.WriteLine("5. Eliminar libro");
    Console.WriteLine("6. Mostrar categorías");
    Console.WriteLine("7. Salir");  
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
            Console.Write("Ingrese el código del libro a buscar: ");
            int codigoBuscar = int.Parse(Console.ReadLine());

            biblioteca.BuscarLibro(codigoBuscar);

            break;

        case 4:
            Console.Write("Ingrese el código del libro: ");
            int codigoModificar = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nuevo número de ejemplares: ");
            int nuevosEjemplares = int.Parse(Console.ReadLine());

            biblioteca.ModificarEjemplares(codigoModificar, nuevosEjemplares);

            break;
        
        case 5:
            Console.Write("Ingrese el código del libro a eliminar: ");
            int codigoEliminar = int.Parse(Console.ReadLine());

            biblioteca.EliminarLibro(codigoEliminar);

            break;

        case 6:
            biblioteca.MostrarCategorias();

            break;

        case 7:

            Console.WriteLine("Saliendo del sistema...");

            break;

        default:

            Console.WriteLine("Opción no válida.");

            break;
    }

} while (opcion != 7);