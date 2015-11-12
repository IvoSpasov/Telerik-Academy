namespace MusicSystem.Tests.Server.Api.ControllerTests
{
    using System.Collections.Generic;
    using System.Web.Http.Results;
    using Data.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Server.Api.Controllers;
    using MusicSystem.Server.Api.Models;
    using MyTested.WebApi;

    [TestClass]
    public class SongsControllerTests
    {
        [TestMethod]
        public void GetShouldReturnOkResultWithAllSongs()
        {
            //var songsController = new SongsController(TestObjectFactory.GetSongsService());
            //var songs = songsController.Get();
            //var okResult = songs as OkNegotiatedContentResult<List<SongResponseModel>>;
            //Assert.IsNotNull(okResult);
            //Assert.AreEqual(1, okResult.Content.Count);

            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
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
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
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
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
                .Calling(c => c.Get(-1))
                .ShouldReturn()
                .NotFound();
        }

        [TestMethod]
        public void GetShouldReturnOkResultWithSong()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
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

        [TestMethod]
        public void PostShouldReturnBadRequestWhenSongIsNull()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
                .Calling(c => c.Post(null))
                .ShouldReturn()
                .BadRequest()
                .WithErrorMessage("Song cannot be null.");
        }

        [TestMethod]
        public void PostShouldValidateModelState()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
                .Calling(c => c.Post(TestObjectFactory.GetInvalidModel()))
                .ShouldHave()
                .InvalidModelState();
        }

        [TestMethod]
        public void PostShouldReturnBadRequestOnInvalidModelState()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
                .Calling(c => c.Post(TestObjectFactory.GetInvalidModel()))
                .ShouldReturn()
                .BadRequest()
                .WithModelStateFor<SongRequestModel>()
                .ContainingModelStateErrorFor(m => m.Title)
                .ContainingModelStateErrorFor(m => m.AlbumTitle)
                .ContainingModelStateErrorFor(m => m.ArtistName)
                .ContainingNoModelStateErrorFor(m => m.Year)
                .ContainingNoModelStateErrorFor(m => m.Genre);
        }

        [TestMethod]
        public void PostShouldReturnOkWithSongId()
        {
            MyWebApi
                .Controller<SongsController>()
                .WithResolvedDependencyFor(TestObjectFactory.GetSongsService())
                .Calling(c => c.Post(TestObjectFactory.GetValidModel()))
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<int>()
                .Passing(id => id == 1);
        }
    }
}
