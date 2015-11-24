namespace Exam.Server.Api.Models.Games
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Common.Constants;

    public class NewGameRequestModel : IValidatableObject
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(ValidationConstants.NumberLength)]
        [MaxLength(ValidationConstants.NumberLength)]
        public string Number { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var digits = this.Number
                .Where(char.IsDigit)
                .Distinct()
                .ToList();

            if (digits.Count() != ValidationConstants.NumberLength)
            {
                yield return new ValidationResult("Number's digits must be distinct");
            }
        }
    }
}