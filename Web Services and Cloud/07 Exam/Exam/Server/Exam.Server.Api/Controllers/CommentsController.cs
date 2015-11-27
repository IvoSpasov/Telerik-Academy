namespace Exam.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Microsoft.AspNet.Identity;
    using Models.Comments;
    using Services.Data.Interfaces;

    [Authorize]
    public class CommentsController : ApiController
    {
        private ICommentsService commentsService;
        private IUserService userService;

        public CommentsController(ICommentsService commentsService, IUserService userService)
        {
            this.commentsService = commentsService;
            this.userService = userService;
        }
        
        public IHttpActionResult Get(int? id, int skip = 0, int take = CommentConstants.CommentsPerPage)
        {
            if (id == null)
            {
                return this.BadRequest("Id must be provided");
            }

            var result = this.commentsService
                .GetCommentsForARealEstate(id.Value, skip, take)
                .ProjectTo<CommentResponseModel>()
                .ToList();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Route("api/Comments/ByUser/{username}")]
        public IHttpActionResult Get(string username, int skip = 0, int take = CommentConstants.CommentsPerPage)
        {
            if (string.IsNullOrEmpty(username))
            {
                return this.BadRequest("Id must be provided");
            }

            string userId = this.userService.GetUserId(username);

            if (string.IsNullOrEmpty(userId))
            {
                return this.BadRequest("No such user.");
            }

            var result = this.commentsService
                .GetCommentsForSepcificUser(userId, skip, take)
                .ProjectTo<CommentResponseModel>()
                .ToList();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(CreateCommentRequestModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Model cannot be null");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            string currentUserId = this.User.Identity.GetUserId();

            var newComment = this.commentsService
                .AddNewComment(model.RealEstateId, model.Content, currentUserId);

            var result = this.commentsService
                .GetCommentDetails(newComment.Id)
                .ProjectTo<CommentResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Format("/api/comments/{0}", newComment.Id), result);
        }
    }
}