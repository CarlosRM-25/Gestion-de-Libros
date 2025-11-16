using System.Collections.Generic;
using System.Linq;
using Gestón_de_Libros.Models;

namespace Gestón_de_Libros.Data
{
    public class LibrosRepo
    {
        private static List<Libro> _libros = new List<Libro>();

        public IEnumerable<Libro> ObtenerLibros()
        {
            return _libros.OrderBy(l => l.Titulo);
        }

        /// <summary>
        /// Devuelve true si se agregó correctamente; false si el código ya existe.
        /// </summary>
        public bool AgregarLibro(Libro libro)
        {
            if (_libros.Any(l => l.CodigoInterno.Equals(libro.CodigoInterno, System.StringComparison.OrdinalIgnoreCase)))
            {
                return false; // código duplicado
            }

            _libros.Add(libro);
            return true;
        }

        // Método opcional para pruebas
        public void Limpiar()
        {
            _libros.Clear();
        }
    }
}
