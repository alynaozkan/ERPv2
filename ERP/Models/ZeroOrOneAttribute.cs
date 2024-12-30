using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class ZeroOrOneAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int intValue && (intValue == 0 || intValue == 1))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Sadece 0 veya 1 girilebilir.");
        }
    }

}
