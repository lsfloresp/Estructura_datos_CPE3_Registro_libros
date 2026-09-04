using System;
using System.Collections.Generic;

public class Biblioteca
{
    private Dictionary<int, Libro> libros = new Dictionary<int, Libro>();

    public void RegistrarLibro(Libro libro)
    {
        if (libros.ContainsKey(libro.Codigo))
        {
            Console.WriteLine("El código del libro ya está registrado.");
            return;
        }

        libros.Add(libro.Codigo, libro);

        Console.WriteLine("Libro registrado correctamente.");
    }
    public void MostrarLibros()
{
    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("           LIBROS REGISTRADOS");
    Console.WriteLine("----------------------------------------");

    if (libros.Count == 0)
    {
        Console.WriteLine("No existen libros registrados.");
        return;
    }

    foreach (Libro libro in libros.Values)
    {
        Console.WriteLine($"Código: {libro.Codigo}");
        Console.WriteLine($"Título: {libro.Titulo}");
        Console.WriteLine($"Autor: {libro.Autor}");
        Console.WriteLine($"Categoría: {libro.Categoria}");
        Console.WriteLine($"Ejemplares: {libro.Ejemplares}");
        Console.WriteLine("----------------------------------------");
    }
}
    public void BuscarLibro(int codigo)
{
    if (libros.ContainsKey(codigo))
    {
        Libro libro = libros[codigo];

        Console.WriteLine("Libro encontrado.");
        Console.WriteLine($"Código: {libro.Codigo}");
        Console.WriteLine($"Título: {libro.Titulo}");
        Console.WriteLine($"Autor: {libro.Autor}");
        Console.WriteLine($"Categoría: {libro.Categoria}");
        Console.WriteLine($"Ejemplares: {libro.Ejemplares}");
    }
    else
    {
        Console.WriteLine("El libro no está registrado.");
    }
}
    public void ModificarEjemplares(int codigo, int nuevosEjemplares)
{
    if (libros.ContainsKey(codigo))
    {
        libros[codigo].Ejemplares = nuevosEjemplares;
        Console.WriteLine("Número de ejemplares actualizado correctamente.");
    }
    else
    {
        Console.WriteLine("El libro no está registrado.");
    }
}
}