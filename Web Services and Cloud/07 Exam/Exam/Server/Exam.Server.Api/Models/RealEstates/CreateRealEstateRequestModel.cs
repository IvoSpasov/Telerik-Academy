namespace Exam.Server.Api.Models.RealEstates
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class CreateRealEstateRequestModel : IValidatableObject
    {
        [Required]
        [MinLength(RealEstateConstants.TitleMinLength)]
        [MaxLength(RealEstateConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(RealEstateConstants.DescriptionMinLength)]
        [MaxLength(RealEstateConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public int ConstructionYear { get; set; }

        [Required]
        public int Type { get; set; }
        
        public decimal SellingPrice { get; set; }
        
        public decimal RentingPrice { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!(1800 < this.ConstructionYear && this.ConstructionYear <= DateTime.Now.Year))
            {
                yield return new ValidationResult("Construction year must be after 1800 and before today.");
            }
        }
    }
}