namespace MusicSystem.Tests.Server.Api
{
    using Moq;
    using Data.Models;
    using Services.Data.Interfaces;
    using System.Linq;
    using System.Collections.Generic;

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
            //songsService.Setup(s => s.SongById(It.Is<int>(id => id == 1)))
            //    .Returns(songs.FirstOrDefault());
            //songsService.Setup(s => s.SongById(It.Is<int>(id => id == -2)))
            //    .Returns(null);
            songsService.Setup(s => s.SongById(
                    It.IsAny<int>()))
                .Returns(songs.FirstOrDefault());
            songsService.Setup(s => s.Add(
                    It.IsAny<Song>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(1);

            return songsService.Object;
        }
    }
}
