namespace MusicSystem.Tests.Server.Api.ControllerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Server.Api.Controllers;
    using MusicSystem.Server.Api.Models;
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
        public void GetShouldReturnOkResultWithData()
        {
            var songsController = new SongsController(this.songsService);
            var songs = songsController.Get();
            var okResult = songs as OkNegotiatedContentResult<List<SongResponseModel>>;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(1, okResult.Content.Count);
        }
    }
}
