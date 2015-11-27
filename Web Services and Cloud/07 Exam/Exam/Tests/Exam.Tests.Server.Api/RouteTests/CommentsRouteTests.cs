namespace Exam.Tests.Server.Api.RouteTests
{
    using Common.Constants;
    using Exam.Server.Api.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;

    [TestClass]
    public class CommentsRouteTests
    {
        [TestMethod]
        public void GetShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Comments/ByUser/ivo")
                .To<CommentsController>(c => c.Get("ivo", 0, CommentConstants.CommentsPerPage));
        }

        [TestMethod]
        public void GetShouldMapCorrectlyWithCustomSkip()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Comments/ByUser/ivo?skip=2")
                .To<CommentsController>(c => c.Get("ivo", 2, CommentConstants.CommentsPerPage));
        }

        [TestMethod]
        public void GetShouldMapCorrectlyWithCustomTake()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Comments/ByUser/ivo?take=18")
                .To<CommentsController>(c => c.Get("ivo", 0, 18));
        }

        [TestMethod]
        public void GetShouldMapCorrectlyWithCustomSkipAndTake()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Comments/ByUser/ivo?skip=22&take=18")
                .To<CommentsController>(c => c.Get("ivo", 22, 18));
        }

        [TestMethod]
        public void GetShouldNotHaveValidModelStateIfNoUsername()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/Comments/ByUser")
                .ToInvalidModelState();
        }
    }
}
