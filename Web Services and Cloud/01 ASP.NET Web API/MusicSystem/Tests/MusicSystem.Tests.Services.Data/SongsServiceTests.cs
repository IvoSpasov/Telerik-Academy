namespace MusicSystem.Tests.Services.Data
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Data.Models;
    using MusicSystem.Services.Data;
    using MusicSystem.Services.Data.Interfaces;
    using System;
    using System.Linq;
    using TestObjects;

    [TestClass]
    public class SongsServiceTests
    {
        private InMemoryRepository<Song> songsRepo;
        private InMemoryRepository<Album> albumsRepo;
        private InMemoryRepository<Artist> artistsRepo;
        private ISongsService songsService;
        private string validArtistName;
        private string validAlbumTitle;

        [TestInitialize]
        public void Init()
        {
            this.songsRepo = TestObjectFactory.GetSongsRepository();
            this.albumsRepo = TestObjectFactory.GetAlbumsRepository();
            this.artistsRepo = TestObjectFactory.GetArtistsRepository();
            this.songsService = new SongsService(songsRepo, albumsRepo, artistsRepo);
            this.validArtistName = this.artistsRepo
                .All()
                .FirstOrDefault()
                .Name
                .ToString();
            this.validAlbumTitle = this.albumsRepo
                .All()
                .FirstOrDefault()
                .Title
                .ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfAlbumTitleIsEmpty()
        {
            var result = this.songsService.Add("Test title", "Test year", Genre.Rock, "", this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfAlbumTitleIsNull()
        {
            var result = this.songsService.Add("Test title", "Test year", Genre.Rock, null, this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddShouldThrowExceptionIfNoAlbumIsFound()
        {
            var result = this.songsService.Add(
                "Test title", 
                "Test year", 
                Genre.Rock, 
                "Invalid album title", 
                this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfArtistTitleIsEmpty()
        {
            var result = this.songsService.Add("Test title", "Test year", Genre.Rock, this.validAlbumTitle, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfArtistTitleIsNull()
        {
            var result = this.songsService.Add("Test title", "Test year", Genre.Rock, this.validAlbumTitle, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddShouldThrowExceptionIfArtistTitleIsNotFound()
        {
            var result = this.songsService.Add(
                "Test title", 
                "Test year", 
                Genre.Rock, 
                this.validAlbumTitle, 
                "Ivalid artist title");
        }
    }
}
