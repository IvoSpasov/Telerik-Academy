namespace StudentSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CourseRequestModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}