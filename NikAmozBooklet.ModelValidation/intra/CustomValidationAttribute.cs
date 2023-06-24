using NikAmozBooklet.ModelValidation.Models;
using System.ComponentModel.DataAnnotations;

namespace NikAmozBooklet.ModelValidation.intra
{
    public class CustomValidationAttribute : ValidationAttribute
    {
        public Type? DbContextType { get; set; }
        public Type? DataType { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (DbContextType != null && DataType != null)
            {
                MvDbContext dbContext = validationContext.GetRequiredService(DbContextType) as MvDbContext;
                if (dbContext!= null && dbContext.Find(DataType,value) ==null)
                {
                    return new ValidationResult(ErrorMessage ?? $"there is no object with promary key {value}");
                }
            }
            return ValidationResult.Success;
        }

    }
}
