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
    /// Contiene el bucle principal de la aplicación.
    /// </summary>
    public static void Main(string[] args)
    {
        bool salir = false;
        
        MostrarTitulo("SISTEMA DE GESTIÓN ACADÉMICA");

        while (!salir)
        {
            MostrarMenu();
            Console.Write("Seleccione una opción: ");
            string entrada = Console.ReadLine();

            // Validar que la entrada sea un número
            if (int.TryParse(entrada, out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ListarCursos();
                        PausarConsola();
                        break;
                    case 2:
                        // Tarea pendiente: Implementar el método de "Agregar Curso"
                        MostrarError("Opción no implementada todavía. Intente con la opción 1 o 0.");
                        PausarConsola();
                        break;
                    case 0:
                        salir = ConfirmarSalida();
                        break;
                    default:
                        MostrarError($"Opción '{opcion}' inválida. Por favor, intente de nuevo.");
                        PausarConsola();
                        break;
                }
            }
            else
            {
                MostrarError("Entrada inválida. Por favor, ingrese el número de la opción.");
                PausarConsola();
            }
            Console.Clear();
        }

        MostrarExito("Gracias por usar el Sistema. ¡Adiós!");
    }

    /// <summary>
    /// Muestra el menú principal de opciones.
    /// </summary>
    static void MostrarMenu()
    {
        MostrarTitulo("MENÚ PRINCIPAL");
        Console.WriteLine("1. Listar Cursos Disponibles");
        Console.WriteLine("2. Agregar Nuevo Curso (PENDIENTE)");
        Console.WriteLine("0. Salir del Sistema");
        Console.WriteLine(new string('-', 30));
    }

    /// <summary>
    /// Muestra todos los cursos disponibles en un formato de tabla claro y legible.
    /// Implementa la TAREA 6 con un enfoque UX para la consola.
    /// </summary>
    static void ListarCursos()
    {
        Console.Clear();
        MostrarTitulo("LISTA COMPLETA DE CURSOS");
        
        // Encabezados claros con alineación y color amarillo
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{"ID",-3} | {"NOMBRE",-30} | {"ÁREA",-25} | {"CRÉDITOS",-8}");
        Console.WriteLine(new string('-', 80));
        Console.ResetColor();
        
        int contador = 0;
        
        foreach (var curso in Cursos.OrderBy(c => c.id))
        {
            // Datos: Blanco (default)
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
        Console.ForegroundColor = ConsoleColor.Green; // Usar color de Éxito para el resumen
        // Resumen final (Total de cursos)
        Console.WriteLine($"TOTAL DE CURSOS EN EL SISTEMA: {Cursos.Count}");
        Console.ResetColor();
    }
    
    // --- Métodos Auxiliares de UX (Tarea 7) ---

    /// <summary>
    /// Muestra un título con formato de color Cyan.
    /// </summary>
    static void MostrarTitulo(string titulo)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n=== {titulo} ===");
        Console.ResetColor();
    }

    /// <summary>
    /// Muestra un mensaje de éxito con color Verde.
    /// </summary>
    static void MostrarExito(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n[ÉXITO] {mensaje}");
        Console.ResetColor();
    }

    /// <summary>
    /// Muestra un mensaje de error con color Rojo.
    /// </summary>
    static void MostrarError(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n[ERROR] {mensaje}");
        Console.ResetColor();
    }

    /// <summary>
    /// Agrega una pausa para que el usuario pueda leer los resultados.
    /// </summary>
    static void PausarConsola()
    {
        Console.WriteLine("\nPresione ENTER para continuar al menú...");
        Console.ReadLine();
    }

    /// <summary>
    /// Pide confirmación al usuario antes de salir.
    /// </summary>
    /// <returns>True si el usuario confirma salir, False en caso contrario.</returns>
    static bool ConfirmarSalida()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("¿Está seguro que desea salir del sistema? (S/N): ");
        Console.ResetColor();
        
        string respuesta = Console.ReadLine()?.Trim().ToUpper();
        
        if (respuesta == "S")
        {
            return true;
        }
        
        // Si no es 'S', se asume que no quiere salir.
        MostrarExito("Operación cancelada. Volviendo al menú.");
        PausarConsola();
        return false;
    }
}