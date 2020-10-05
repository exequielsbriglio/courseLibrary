using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "El titulo debe ser diferente a la descripcion")] // se reemplaza por este tag

    public abstract class CourseForManipulationDto /*: IValidatableObject*/
    {
        [Required(ErrorMessage = "Es Obligatorio el titulo")]
        [MaxLength(100, ErrorMessage = "El titulo no deberia ser mayor a 100 caracteres")]
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "la descripcion no debe ser mayor a 1500 caracteres")]
        public virtual string Description { get; set; }

        //    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //    {
        //        if (Title == Description)
        //        {
        //            yield return  new ValidationResult(
        //                "La descripcion deberia ser diferente de el titulo.",
        //                new[]{"CourseForCreationDto"});
        //        }
        //    }
    }
}
