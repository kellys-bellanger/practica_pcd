// TAREA 5 - Funcionalidad de búsqueda avanzada
// Desarrollador C# 2 (jimmy)

using System;
using System.Collections.Generic;
using System.Linq; 

namespace SistemaAcademico
{
    class Program
    {
        // Lista de cursos (reutilizada de TAREA 3)
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
            Console.Clear();
            Console.WriteLine("📘 SISTEMA ACADÉMICO - MENÚ PRINCIPAL\n");
            Console.WriteLine("1. Mostrar lista de cursos");
            Console.WriteLine("2. Buscar cursos");
            Console.WriteLine("0. Salir");

            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    MostrarCursos();
                    break;
                case "2":
                    BuscarCursos();
                    break;
                case "0":
                    Console.WriteLine("👋 Saliendo del sistema...");
                    return;
                default:
                    Console.WriteLine("❌ Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        //  Método para mostrar la lista de cursos
        static void MostrarCursos()
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE CURSOS ===\n");

            foreach (var curso in Cursos)
            {
                Console.WriteLine($"[{curso.id}] {curso.nombre} - {curso.area} ({curso.creditos} créditos)");
            }

            Console.WriteLine($"\nTotal de cursos: {Cursos.Count}");
        }

        //  Método para búsqueda avanzada de cursos
        static void BuscarCursos()
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR CURSOS ===");
            Console.Write("Ingrese término de búsqueda: ");
            string termino = Console.ReadLine() ?? "";

            var resultados = Cursos
                .Where(c =>
                    c.nombre.Contains(termino, StringComparison.OrdinalIgnoreCase) ||
                    c.area.Contains(termino, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine($"\nResultados para '{termino}':");
            if (resultados.Count == 0)
            {
                Console.WriteLine("⚠️ No se encontraron cursos que coincidan con la búsqueda.");
            }
            else
            {
                foreach (var curso in resultados)
                {
                    Console.WriteLine($"[{curso.id}] {curso.nombre} - {curso.area} ({curso.creditos} créditos)");
                }
                Console.WriteLine($"\n✅ Total: {resultados.Count} curso(s) encontrado(s)");
            }
        }
    }
}
