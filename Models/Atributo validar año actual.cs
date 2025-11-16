using System;
using System.ComponentModel.DataAnnotations;

namespace Gestón_de_Libros.Models
{
    public class CurrentYearOrEarlierAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return true; // [Required] se encarga
            if (int.TryParse(value.ToString(), out int year))
            {
                return year <= DateTime.Now.Year;
            }
            return false;
        }
    }
}
