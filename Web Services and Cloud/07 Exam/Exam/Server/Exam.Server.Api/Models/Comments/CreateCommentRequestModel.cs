namespace Exam.Server.Api.Models.Comments
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class CreateCommentRequestModel
    {
        [Required]
        public int RealEstateId { get; set; }

        [Required]
        [MinLength(CommentConstants.ContentMinLength)]
        [MaxLength(CommentConstants.ContentMaxLength)]
        public string Content { get; set; }
    }
}