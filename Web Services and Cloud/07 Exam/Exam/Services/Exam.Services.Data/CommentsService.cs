namespace Exam.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
    using Exam.Data.Common.Repositories;
    using Exam.Data.Models;
    using Interfaces;

    public class CommentsService : ICommentsService
    {
        private IRepository<Comment> commentsRepo;

        public CommentsService(IRepository<Comment> commentsRepo)
        {
            this.commentsRepo = commentsRepo;
        }

        public IQueryable<Comment> GetCommentDetails(int id)
        {
            return this.commentsRepo
                .All()
                .Where(c => c.Id == id);
        }

        public IQueryable<Comment> GetCommentsForARealEstate(int realEstateId, int skip = 0, int take = CommentConstants.CommentsPerPage)
        {
            var comments = this.commentsRepo
                .All()
                .Where(c => c.RealEstateId == realEstateId)
                .OrderByDescending(c => c.CreatedOn)
                .Skip(skip)
                .Take(take);

            return comments;
        }

        public IQueryable<Comment> GetCommentsForSepcificUser(string userId, int skip = 0, int take = CommentConstants.CommentsPerPage)
        {
            var comments = this.commentsRepo
              .All()
              .Where(c => c.UserId == userId)
              .OrderByDescending(c => c.CreatedOn)
              .Skip(skip)
              .Take(take);

            return comments;
        }

        public Comment AddNewComment(int realEstateId, string content, string userId)
        {
            var newComment = new Comment()
            {
                Content = content,
                CreatedOn = DateTime.Now,
                RealEstateId = realEstateId,
                UserId = userId
            };

            this.commentsRepo.Add(newComment);
            this.commentsRepo.SaveChanges();

            return newComment;
        }
    }
}
