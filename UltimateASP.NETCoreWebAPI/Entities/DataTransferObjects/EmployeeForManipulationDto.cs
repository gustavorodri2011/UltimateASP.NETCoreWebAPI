using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class EmployeeForManipulationDto
    {
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is {1} characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Employee age is a required field.")]
        [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower than 18")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Employee position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is {1} characters.")]
        public string Position { get; set; }
    }
}
