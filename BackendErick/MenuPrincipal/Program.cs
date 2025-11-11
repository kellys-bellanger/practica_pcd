﻿// ================================================================
// PROYECTO: práctica_pcd
// DESARROLLADOR: Jimmy (C# Developer)
// TAREAS INTEGRADAS: 2, 3 y 4
// ---------------------------------------------------------------
// TAREA 2: Creación del proyecto y estructura base
// TAREA 3: Modelo de datos y lista de cursos
// TAREA 4: Implementación del menú principal interactivo
// ================================================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico
{
    /// <summary>
    /// Clase principal del sistema académico.
    /// Contiene el punto de entrada del programa y la lógica del menú principal.
    /// </summary>
    class Program
    {
        // ================================================================
        // LISTA DE CURSOS (Tarea 3)
        // Estructura: id, nombre, área y créditos
        // ================================================================
        static List<(int id, string nombre, string area, int creditos)> Cursos = new()
        {
            (1, "Algoritmos I", "Ciencia de la Computación", 4),
            (2, "Introducción a la Programación", "Ciencia de la Computación", 3),
            (3, "Matemática Discreta", "Matemáticas", 4),
            (4, "Bases de Datos", "Ciencia de la Computación", 3),
            (5, "Estadística I", "Matemáticas", 3)
        };

        // ================================================================
        // MÉTODO PRINCIPAL (Tarea 4)
        // Controla el flujo del menú interactivo y la navegación entre opciones
        // ================================================================
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== CATÁLOGO DE CURSOS ===");
                Console.WriteLine("1. Listar todos los cursos");
                Console.WriteLine("2. Buscar cursos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ListarCursos();
                        break;

                    case "2":
                        BuscarCursos();
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("\nSaliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente nuevamente.");
                        break;
                }

                // Pausa para permitir al usuario leer los resultados
                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // ================================================================
        // FUNCIÓN: ListarCursos()
        // Muestra todos los cursos disponibles de la lista estática
        // ================================================================
        static void ListarCursos()
        {
            Console.Clear();
            Console.WriteLine("📋 LISTA DE CURSOS DISPONIBLES:\n");

            // Encabezado de tabla
            Console.WriteLine($"{"ID",-5} {"Nombre",-30} {"Área",-25} {"Créditos",-10}");
            Console.WriteLine(new string('-', 75));

            // Iteración sobre la lista de cursos
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"{curso.id,-5} {curso.nombre,-30} {curso.area,-25} {curso.creditos,-10}");
            }

            Console.WriteLine($"\nTotal de cursos: {Cursos.Count}");
        }

        // ================================================================
        // FUNCIÓN: BuscarCursos()
        // Permite al usuario buscar por nombre o área
        // ================================================================
        static void BuscarCursos()
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR CURSOS ===");
            Console.Write("Ingrese texto para buscar (por nombre o área): ");
            string texto = Console.ReadLine()?.ToLower() ?? "";

            // Búsqueda usando LINQ (filtro por nombre o área)
            var resultados = Cursos
                .Where(c => c.nombre.ToLower().Contains(texto) || c.area.ToLower().Contains(texto))
                .ToList();

            if (resultados.Count > 0)
            {
                Console.WriteLine("\nResultados encontrados:");
                Console.WriteLine($"{"ID",-5} {"Nombre",-30} {"Área",-25} {"Créditos",-10}");
                Console.WriteLine(new string('-', 75));

                foreach (var curso in resultados)
                {
                    Console.WriteLine($"{curso.id,-5} {curso.nombre,-30} {curso.area,-25} {curso.creditos,-10}");
                }
            }
            else
            {
                Console.WriteLine("\nNo se encontraron cursos con ese criterio.");
            }
        }
    }
}
