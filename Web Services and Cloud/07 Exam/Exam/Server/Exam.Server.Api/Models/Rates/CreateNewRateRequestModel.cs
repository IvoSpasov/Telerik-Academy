namespace Exam.Server.Api.Models.Rates
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateNewRateRequestModel : IValidatableObject
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public int Value { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Value < 1 || 5 < this.Value)
            {
                yield return new ValidationResult("value must be between 1 and 5");
            }
        }
    }
}