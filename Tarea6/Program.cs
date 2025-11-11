using System;
using System.Collections.Generic;
using System.Linq;

// Clase Curso (Dependencia: Tarea 3)
public class Curso
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string area { get; set; }
    public int creditos { get; set; }

    public Curso(int id, string nombre, string area, int creditos)
    {
        this.id = id;
        this.nombre = nombre;
        this.area = area;
        this.creditos = creditos;
    }
}

public class Program
{
    // Lista estática de cursos (Dependencia: Tarea 3)
    private static List<Curso> Cursos = new List<Curso>
    {
        new Curso(1, "Introducción a C#", "Desarrollo de Software", 6),
        new Curso(2, "Diseño UX/UI", "Experiencia de Usuario", 4),
        new Curso(3, "Bases de Datos SQL", "Ciencia de Datos", 8),
        new Curso(4, "Redes y Seguridad", "Infraestructura", 5),
        new Curso(5, "Algoritmos Avanzados y Estructuras de Datos", "Desarrollo de Software", 10),
        new Curso(6, "Gestión de Proyectos Ágiles (Scrum)", "Metodologías", 3),
        new Curso(7, "Contabilidad Financiera", "Negocios", 4),
        new Curso(8, "Marketing Digital y SEO", "Negocios", 5)
    };

    /// <summary>
    /// Método principal para ejecutar el programa.
    /// Este código está diseñado para ser ejecutado como una aplicación de consola en Visual Studio Code.
    /// </summary>
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Sistema de Gestión de Cursos.");
        Console.WriteLine("Presiona Enter para listar los cursos...");
        Console.ReadLine();
        
        // Llamada al método implementado para la Tarea 6
        ListarCursos();
        
        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    /// <summary>
    /// Muestra todos los cursos disponibles en un formato de tabla claro y legible.
    /// Implementa la TAREA 6 con un enfoque UX para la consola.
    /// </summary>
    static void ListarCursos()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== LISTA COMPLETA DE CURSOS ===");
        Console.WriteLine(new string('=', 60));
        Console.ResetColor();

        // Encabezados claros con alineación
        Console.WriteLine($"{"ID",-3} | {"NOMBRE",-30} | {"ÁREA",-25} | {"CRÉDITOS",-8}");
        Console.WriteLine(new string('-', 80));
        
        int contador = 0; // Usado para paginación/agrupación simulada
        
        foreach (var curso in Cursos.OrderBy(c => c.id))
        {
            // Muestra la información completa y alineada de cada curso
            // ID: 3 espacios, alineado a la izquierda.
            // Nombre: 30 espacios, alineado a la izquierda.
            // Área: 25 espacios, alineado a la izquierda.
            // Créditos: 8 espacios, alineado a la izquierda.
            Console.WriteLine($"{curso.id,-3} | {curso.nombre,-30} | {curso.area,-25} | {curso.creditos,-8}");
            contador++;

            // Paginación Simulada / Agrupación: Inserta un separador cada 5 cursos para mejorar la legibilidad visual.
            if (contador % 5 == 0 && contador < Cursos.Count)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(new string('.', 80));
                Console.ResetColor();
            }
        }
        
        Console.WriteLine(new string('-', 80));
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Resumen final (Total de cursos)
        Console.WriteLine($"TOTAL DE CURSOS EN EL SISTEMA: {Cursos.Count}");
        Console.ResetColor();
    }
}