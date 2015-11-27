namespace Exam.Tests.Server.Api.ControllerTests
{
    using System.Collections.Generic;
    using Exam.Server.Api.Controllers;
    using Exam.Server.Api.Models.Comments;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;

    [TestClass]
    public class CommentsControllerTests
    {
        [TestMethod]
        public void GetShouldReturnBadRequestWhenUsernameIsNull()
        {
            MyWebApi
                .Controller<CommentsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetCommentsService())
                .AndAlso()
                .WithResolvedDependencyFor(TestObjectFactory.GetUsersService())
                .Calling(c => c.Get((string)null, 0, 10))
                .ShouldReturn()
                .BadRequest()
                .WithErrorMessage("Id must be provided");
        }

        [TestMethod]
        public void GetShouldReturnBadRequestWhenInvalidUser()
        {
            MyWebApi
                .Controller<CommentsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetCommentsService())
                .AndAlso()
                .WithResolvedDependencyFor(TestObjectFactory.GetUsersService())
                .Calling(c => c.Get("invalidUsername", 0, 10))
                .ShouldReturn()
                .BadRequest()
                .WithErrorMessage("No such user.");
        }

        [TestMethod]
        public void GetShouldReturnOkResultWithAllComments()
        {
            MyWebApi
                .Controller<CommentsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetCommentsService())
                .AndAlso()
                .WithResolvedDependencyFor(TestObjectFactory.GetUsersService())
                .Calling(c => c.Get("validUsername", 0, 10))
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<List<CommentResponseModel>>()
                .Passing(pr => pr.Count == 1);
        }
    }
}
