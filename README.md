# Catálogo de Cursos - Consola C# 📚

Este proyecto es una aplicación de consola desarrollada en C# que permite a los usuarios interactuar con un catálogo de cursos.

## Funcionalidades Principales ✨
* Menú interactivo de consola para navegación.
* Listado completo y paginado de cursos disponibles.
* Búsqueda eficiente por nombre o área temática.
* Interfaz amigable para una mejor experiencia de usuario.

---

## 💻 Requisitos del Sistema

Para compilar y ejecutar esta aplicación, necesitarás lo siguiente:

* **.NET SDK:** Versión **6.0 o superior** (Se recomienda la última versión LTS, actualmente .NET 8, para mayor soporte y rendimiento).
* **Sistema Operativo:** Compatible con Windows, Linux o macOS.
* **Editor de Código:** Recomendado Visual Studio Code, Visual Studio o JetBrains Rider.

## 🚀 Compilación y Ejecución

1. Navegar al Directorio
Abre la terminal y navega hasta el directorio raíz donde se encuentra el archivo `.csproj` del proyecto:
Compilación y Ejecución (dentro de la terminal)
I. Clonar el Repositorio
Abre tu Terminal/Línea de Comandos.
Clona el repositorio de GitHub:
Bash
git clone https://github.com/kellys-bellanger/practica-pcd.git
Navega al directorio del proyecto:
Bash
cd practica-pcd
II. Instalar Dependencias (Si es necesario)
Asegúrate de tener instalado el SDK de .NET.
Restaura las dependencias del proyecto:
Bash
dotnet restore
III. Ejecutar el Proyecto
Ejecuta el programa desde la línea de comandos:
Bash
dotnet run
El sistema mostrará el menú principal: CATÁLOGO DE CURSOS ===.
Ingresa 1 para Listar todos los cursos.
Ingresa 2 para Buscar cursos (por nombre o área).
Ingresa 3 para Salir del sistema.



Tarea 9 
PASO 1: Probar que compila sin errores
Esra construido correctamente, nos envio el mensaje de "Build succeeded"

PASO 2: Probar cada función del menú
1. Ejecutar: dotnet run
<img width="636" height="706" alt="image" src="https://github.com/user-attachments/assets/9dbf8817-36c2-4601-9453-59397eef46b2" />
2. Probar Opción 1: "Listar todos los cursos"
   - ¿Muestra 5 cursos?
<img width="671" height="493" alt="image" src="https://github.com/user-attachments/assets/2eebfdaa-c91d-4af1-8bee-d071e2b2acbb" />
3. Probar Opción 2: "Buscar cursos"
   - Buscar "algo" → ¿aparece "Algoritmos I"?
      <img width="667" height="375" alt="image" src="https://github.com/user-attachments/assets/65bcf0cc-e6ea-4eaf-a23a-5126c1b18195" />
   - Buscar "mate" → ¿aparecen cursos de matemáticas?
   <img width="675" height="434" alt="image" src="https://github.com/user-attachments/assets/6844889c-433f-4989-9f73-073222bc5cd5" />

   - Buscar "xyz" → ¿dice "No se encontraron cursos"?
     <img width="584" height="241" alt="image" src="https://github.com/user-attachments/assets/d456e4c6-e4a0-49ed-bff3-7463b69408dc" />

<img width="663" height="255" alt="image" src="https://github.com/user-attachments/assets/631fe2b6-7461-44d1-bcec-a43cad5b628e" />

4. Probar Opción 3: "Salir"
   - ¿La aplicación se cierra correctamente?
<img width="639" height="165" alt="image" src="https://github.com/user-attachments/assets/5a996c2c-8410-4842-83fc-235f5a9320f8" />
PASO 3: Verificar el Definition of Done (DoD)
# CHECKLIST DoD - Marcar con ✅ o ❌

## CRITERIOS MÍNIMOS:
[ ] La aplicación compila sin errores
[ ] La aplicación ejecuta sin crashear
[ ] Muestra lista de 3-5 cursos estáticos
[ ] Permite buscar/filtrar cursos
[ ] README explica cómo ejecutar
[ ] Trello tiene tareas con responsable y fecha
[ ] Hay evidencia (capturas/enlaces) de lo hecho
[ ] Vista calendario configurada en Trello
[ ] Reporte de estado completado





