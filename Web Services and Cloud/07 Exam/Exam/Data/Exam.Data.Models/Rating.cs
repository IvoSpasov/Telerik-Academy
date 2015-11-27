namespace Exam.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Rating : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Value < 1 || 5 < this.Value)
            {
                yield return new ValidationResult("value must be between 1 and 5");
            }
        }
    }
}
