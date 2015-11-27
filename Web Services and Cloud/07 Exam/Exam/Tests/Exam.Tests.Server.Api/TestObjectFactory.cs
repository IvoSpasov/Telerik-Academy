namespace Exam.Tests.Server.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data.Models;
    using Moq;
    using Services.Data.Interfaces;

    public static class TestObjectFactory
    {
        private static IQueryable<Comment> comments = new List<Comment>()
        {
            new Comment
            {
                Content = "Test Content",
                CreatedOn = DateTime.Now
            }
        }.AsQueryable();

        public static IUserService GetUsersService()
        {
            var userService = new Mock<IUserService>();

            userService.Setup(s => s.GetUserId("validUsername"))
                .Returns("validUserId");

            userService.Setup(s => s.GetUserId("invalidUsername"))
                .Returns((string)null);

            return userService.Object;
        }

        public static ICommentsService GetCommentsService()
        {
            var commentsService = new Mock<ICommentsService>();

            commentsService.Setup(s => s.GetCommentsForSepcificUser(
                    It.IsAny<string>(),
                    It.IsAny<int>(),
                    It.IsAny<int>()))
                .Returns(comments);

            return commentsService.Object;
        }
    }
}
