using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please provide your name")]
        [RegularExpression(@"^[a-zA-Z\s\.]{1,100}$", ErrorMessage = "Please enter a valid name with alphabets, spaces, and dots (up to 100 characters).")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a username")]
        [StringLength(15, ErrorMessage = "Username should not exceed 15 characters")]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Username should not exceed 15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please select a gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select at least one profession")]
        public string[] Professions { get; set; }

        [Required(ErrorMessage = "Please enter a valid date of birth")]
        [DataType(DataType.Date)]
        [MinimumAge(20, ErrorMessage = "Age must be greater than 20")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please enter a valid student ID in the format xx-xxxxx-xx")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "Please enter a valid student ID in the format xx-xxxxx-xx")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Please enter a valid email in the format xx-xxxxx-xx@student.aiub.edu")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}@student.aiub.edu$", ErrorMessage = "Please enter a valid email in the format xx-xxxxx-xx@student.aiub.edu")]
        public string Email { get; set; }
    }

    // Custom validation attribute to check minimum age
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                var age = DateTime.Today.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Today.AddYears(-age))
                    age--;

                if (age < _minimumAge)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}
