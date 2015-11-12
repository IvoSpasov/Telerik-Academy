namespace MusicSystem.Tests.Server.Api
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Models;
    using Moq;
    using MusicSystem.Server.Api.Models.Songs;
    using Services.Data.Interfaces;

    public static class TestObjectFactory
    {
        private static IQueryable<Song> songs = new List<Song>()
        {
            new Song
            {
                Title = "Test title",
                Year = "Test year",
                Genre = Genre.Rock
            }
        }.AsQueryable();

        public static ISongsService GetSongsService()
        {
            var songsService = new Mock<ISongsService>();
            songsService.Setup(s => s.All())
                .Returns(songs);

            songsService.Setup(s => s.SongById(It.Is<int>(id => id == 1)))
                .Returns(songs.FirstOrDefault());

            songsService.Setup(s => s.SongById(It.Is<int>(id => id == -1)))
                .Returns((Song)null);

            songsService.Setup(s => s.Add(
                    It.IsAny<Song>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(1);

            return songsService.Object;
        }

        public static SongRequestModel GetInvalidModel()
        {
            return new SongRequestModel()
            {
                Year = "Test year"
            };
        }

        public static SongRequestModel GetValidModel()
        {
            return new SongRequestModel()
            {
                Title = "Test title",
                AlbumTitle = "Test album title",
                ArtistName = "Test artist name"
            };
        }
    }
}
