namespace MusicSystem.Tests.Server.Api.RouteTests
{
    using System.Net.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Server.Api.Controllers;
    using MusicSystem.Server.Api.Models;
    using MyTested.WebApi;

    [TestClass]
    public class SongsControllerTests
    {
        [TestMethod]
        public void GetShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/songs")
                .To<SongsController>(c => c.Get());
        }

        [TestMethod]
        public void GetWithIdShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/songs/1")
                .To<SongsController>(c => c.Get(1));
        }

        [TestMethod]
        public void PostShouldMapCorrectly()
        {
            MyWebApi
                .Routes()
                .ShouldMap("api/songs")
                .WithHttpMethod(HttpMethod.Post)
                .WithJsonContent(@"{ ""Title"": ""Test"", ""AlbumTitle"": ""Test album"", ""ArtistName"": ""Test artist"" }")
                .To<SongsController>(c => c.Post(new SongRequestModel
                {
                    Title = "Test",
                    AlbumTitle = "Test album",
                    ArtistName = "Test artist"
                }));
        }
    }
}
