# Gestion-de-Libros

# Proyecto ASP.NET Core MVC
## Objetivo General

Desarrollar una aplicación web en ASP.NET Core MVC que permita:

* Registrar libros mediante un formulario con validaciones.
* Mostrar el listado de libros registrados.
* Aplicar correctamente el patrón MVC y separación de responsabilidades.
* Utilizar un repositorio en memoria.

---

## Historia del Cliente – "Biblioteca Campus U"

La biblioteca requiere una herramienta simple para agregar libros a su catálogo. El sistema debe ser fácil de usar y permitir ver los libros ingresados inmediatamente en una tabla.

---

## Datos que se registran

Cada libro incluye:

* **Título**
* **Autor**
* **Categoría** (Programación, Redes, Bases de Datos, IA, Otro)
* **Año de publicación**
* **Número de páginas**
* **Código interno** (formato `LIB-###`)
* **Disponible** (Sí/No)

---

## Validaciones Aplicadas

### **Título y Autor**

* Obligatorios
* Mínimo 3 caracteres

### **Categoría**

* Obligatoria
* No se permite "Seleccione..."

### **Año de publicación**

* Entre **1900** y año actual
* No puede ser un valor futuro
* Validado con un atributo personalizado `CurrentYearOrEarlier`

### **Número de páginas**

* Obligatorio
* Mayor que 0

### **Código Interno**

* Obligatorio
* Formato `LIB-###`
* **Debe ser único** (validación manual en el repositorio/controlador)

### **Disponible**

* Valor booleano obligatorio

---

## Estructura del Proyecto

```
/Controllers
    LibroController.cs
/Models
    Libro.cs
    CurrentYearOrEarlierAttribute.cs
/Data
    LibroRepository.cs
/Views/Libro
    Index.cshtml
    Crear.cshtml
Program.cs
```

---

## Principales Componentes

### **Modelo: `Libro.cs`**

Contiene las propiedades del libro y validaciones con DataAnnotations.

### **Repositorio: `LibroRepository.cs`**

Maneja una lista estática en memoria:

```
private static List<Libro> _libros = new List<Libro>();
```

Incluye métodos para agregar y obtener libros.

### **Controlador: `LibroController.cs`**

* `Index()` → Muestra listado.
* `Crear()` (GET) → Formulario vacío.
* `Crear(Libro libro)` (POST) → Valida y agrega libro.

### **Vistas:**

* **Index.cshtml** → Tabla de libros.
* **Crear.cshtml** → Formulario de registro.

---

## Pasos de Desarrollo (Guía para el estudiante)

### **Fase 1 – Creación del Proyecto**

1. Crear un proyecto ASP.NET Core MVC en Visual Studio 2022.
2. Inicializar repositorio Git.
3. Crear commit inicial.

### **Fase 2 – Modelo**

* Crear `Libro.cs` con anotaciones.
* Crear atributo personalizado.

### **Fase 3 – Repositorio**

* Crear `LibroRepository.cs` con lista en memoria.

### **Fase 4 – Controlador**

* Crear `LibroController.cs`.
* Implementar validaciones y TempData.

### **Fase 5 – Vistas**

* `Index.cshtml`
* `Crear.cshtml`
* Bootstrap para estilos.

### **Fase 6 – Mejoras opcionales**

* Agregar edición/eliminación.
* Inyectar repositorio con DI.

---

## Validaciones Importantes

* El formato del código interno se verifica con:

```
[RegularExpression(@"^LIB-\\d{3}$")]
```

* El repositorio evita duplicados.
* El atributo personalizado impide años futuros.

---

## Capturas Requeridas

El estudiante deberá entregar:

* Formulario de registro con validaciones visibles.
* Tabla de libros en el listado.
* Ejemplo de código duplicado rechazado.
* Historial de commits en GitHub.

---

## Uso de GIT (evidencias obligatorias)

1. Commits frecuentes y descriptivos.
2. Crear al menos una rama:

```
feature/registro-libros
```

3. Subir a GitHub.
4. Realizar merge a main.

---

## Ejecución del Proyecto

1. Abrir la solución en Visual Studio 2022.
2. Ejecutar con IIS Express o Kestrel.
3. Acceder a:

```
https://localhost:xxxx/Libro/Index
```

---

## Notas Finales

Este proyecto corresponde a la práctica del módulo ASP.NET Core MVC e incluye:

* Validaciones completas
* Uso de MVC
* Repositorio en memoria
* Bootstrap para estética básica
* Evidencias para evaluación académica

---

Si deseas, puedo agregar diagramas, explicación extendida del patrón MVC o instrucciones para deploy. 😊
