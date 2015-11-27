namespace Exam.Services.Data.Interfaces
{
    using System.Linq;
    using Common.Constants;
    using Exam.Data.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> GetCommentDetails(int id);

        IQueryable<Comment> GetCommentsForARealEstate(int realEstateId, int skip = 0, int take = CommentConstants.CommentsPerPage);

        IQueryable<Comment> GetCommentsForSepcificUser(string userId, int skip = 0, int take = CommentConstants.CommentsPerPage);

        Comment AddNewComment(int realEstateId, string content, string userId);
    }
}
