using System;

Biblioteca biblioteca = new Biblioteca();

Console.WriteLine("----------------------------------------");
Console.WriteLine("          REGISTRO DE LIBRO");
Console.WriteLine("----------------------------------------");

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