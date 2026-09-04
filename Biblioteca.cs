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
}