namespace MusicSystem.Tests.Server.Api.ControllerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Data.Models;
    using MusicSystem.Server.Api.Controllers;
    using MusicSystem.Server.Api.Models;
    using MyTested.WebApi;
    using Services.Data.Interfaces;
    using System.Collections.Generic;
    using System.Web.Http.Results;

    [TestClass]
    public class SongsControllerTests
    {
        private ISongsService songsService;

        [TestInitialize]
        public void TestInit()
        {
            this.songsService = TestObjectFactory.GetSongsService();
        }

        [TestMethod]
        public void GetShouldReturnOkResultWithAllSongs()
        {
            //var songsController = new SongsController(this.songsService);
            //var songs = songsController.Get();
            //var okResult = songs as OkNegotiatedContentResult<List<SongResponseModel>>;
            //Assert.IsNotNull(okResult);
            //Assert.AreEqual(1, okResult.Content.Count);

            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(this.songsService)
                .Calling(c => c.Get())
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<List<SongResponseModel>>()
                .Passing(pr => pr.Count == 1);
        }

        [TestMethod]
        public void GetShouldReturnBadRequestWhenIdIsNull()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(this.songsService)
                .Calling(c => c.Get(null))
                .ShouldReturn()
                .BadRequest()
                .WithErrorMessage("Song id cannot be null.");
        }

        [TestMethod]
        public void GetShouldRetrunNotFoundWhenSongIsNull()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(this.songsService)
                .Calling(c => c.Get(-1))
                .ShouldReturn()
                .NotFound();
        }

        [TestMethod]
        public void GetShouldReturnOkResultWithSong()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(this.songsService)
                .Calling(c => c.Get(1))
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<SongResponseModel>()
                .Passing(pr => 
                {
                    Assert.AreEqual("Test title", pr.Title);
                    Assert.AreEqual("Test year", pr.Year);
                    Assert.AreEqual(Genre.Rock, pr.Genre);
                });
        }
    }
}
