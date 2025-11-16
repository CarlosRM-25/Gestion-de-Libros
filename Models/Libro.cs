using System;
using System.ComponentModel.DataAnnotations;

namespace Gestón_de_Libros.Models
{
    public class Libro
    {
        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "El título debe tener al menos 3 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El autor debe tener al menos 3 caracteres.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public string Categoria { get; set; } // Opciones: Programación, Redes, Bases de Datos, IA, Otro

        [Required(ErrorMessage = "El año de publicación es obligatorio.")]
        [Range(1900, 9999, ErrorMessage = "El año debe ser entre 1900 y el año actual.")]
        [CurrentYearOrEarlier(ErrorMessage = "El año no puede ser mayor al año actual.")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de páginas debe ser mayor que 0.")]
        public int NumeroPaginas { get; set; }

        [Required(ErrorMessage = "El código interno es obligatorio.")]
        [RegularExpression(@"^LIB-\d{3}$", ErrorMessage = "El código debe tener el formato LIB-### (ej. LIB-001).")]
        public string CodigoInterno { get; set; }

        [Required(ErrorMessage = "Debe indicar si está disponible.")]
        public bool Disponible { get; set; }
    }
}
