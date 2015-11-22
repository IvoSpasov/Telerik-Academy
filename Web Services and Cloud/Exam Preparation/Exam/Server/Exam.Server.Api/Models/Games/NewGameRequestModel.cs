namespace Exam.Server.Api.Models.Games
{
    using System.ComponentModel.DataAnnotations;

    public class NewGameRequestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }
    }
}