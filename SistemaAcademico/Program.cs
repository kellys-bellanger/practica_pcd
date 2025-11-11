// TAREA 3 - Modelo de datos y lista de cursos
// Desarrollador C# 2 (Jimmy)

using System;
using System.Collections.Generic;

namespace SistemaAcademico
{
    class Program
    {
        static List<(int id, string nombre, string area, int creditos)> Cursos = new()
        {
            (1, "Algoritmos I", "Ciencia de la Computación", 4),
            (2, "Introducción a la Programación", "Ciencia de la Computación", 3),
            (3, "Matemática Discreta", "Matemáticas", 4),
            (4, "Bases de Datos", "Ciencia de la Computación", 3),
            (5, "Estadística I", "Matemáticas", 3)
        };

        static void Main(string[] args)
        {
            Console.WriteLine("📋 LISTA DE CURSOS DISPONIBLES:\n");

            foreach (var curso in Cursos)
            {
                Console.WriteLine($"ID: {curso.id}");
                Console.WriteLine($"Nombre: {curso.nombre}");
                Console.WriteLine($"Área: {curso.area}");
                Console.WriteLine($"Créditos: {curso.creditos}");
                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine("\n Total de cursos cargados: " + Cursos.Count);
            Console.ReadKey();
        }
    }
}