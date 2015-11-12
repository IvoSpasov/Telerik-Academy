namespace MusicSystem.Tests.Services.Data
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Data.Models;
    using MusicSystem.Services.Data;
    using MusicSystem.Services.Data.Interfaces;
    using TestObjects;

    // Repositories and data layer testing
    [TestClass]
    public class SongsServiceTests
    {
        private InMemoryRepository<Song> songsRepo;
        private InMemoryRepository<Album> albumsRepo;
        private InMemoryRepository<Artist> artistsRepo;
        private ISongsService songsService;
        private string validArtistName;
        private string validAlbumTitle;
        private Song testSong;

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
            this.testSong = new Song()
            {
                Title = "Test title",
                Year = "Test year",
                Genre = Genre.Rock
            };
        }

        [TestMethod]
        public void AllShouldReturnAllSongs()
        {
            var actualSongsCount = this.songsService.All().Count();
            var expectedSongsCount = this.songsRepo.All().Count();
            Assert.AreEqual(expectedSongsCount, actualSongsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SongByIdShouldThrowExceptionIfIdIsNull()
        {
            var result = this.songsService.SongById(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfSongIsNull()
        {
            var result = this.songsService.Add(null, this.validAlbumTitle, this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfAlbumTitleIsEmpty()
        {
            var result = this.songsService.Add(this.testSong, "", this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfAlbumTitleIsNull()
        {
            var result = this.songsService.Add(this.testSong, null, this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddShouldThrowExceptionIfNoAlbumIsFound()
        {
            var result = this.songsService.Add(this.testSong, "Invalid album title", this.validArtistName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfArtistTitleIsEmpty()
        {
            var result = this.songsService.Add(this.testSong, this.validAlbumTitle, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddShouldThrowExceptionIfArtistTitleIsNull()
        {
            var result = this.songsService.Add(this.testSong, this.validAlbumTitle, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddShouldThrowExceptionIfArtistTitleIsNotFound()
        {
            var result = this.songsService.Add(this.testSong, this.validAlbumTitle, "Ivalid artist title");
        }

        [TestMethod]
        public void AddShouldInvokeSaveChanges()
        {
            var result = this.songsService.Add(this.testSong, this.validAlbumTitle, this.validArtistName);

            Assert.AreEqual(1, this.songsRepo.NumberOfSaves);
        }

        [TestMethod]
        public void AddShouldPopulateSongToDatabase()
        {
            const string SongTitle = "Test title";
            var result = this.songsService.Add(this.testSong, this.validAlbumTitle, this.validArtistName);
            var song = this.songsRepo.All().FirstOrDefault(s => s.Title == SongTitle);

            Assert.IsNotNull(song);
            Assert.AreEqual(SongTitle, song.Title);
            Assert.AreEqual("Test year", song.Year);
            Assert.AreEqual(Genre.Rock, song.Genre);
            Assert.AreEqual(this.validAlbumTitle, song.Album.Title);
            Assert.AreEqual(this.validArtistName, song.Artist.Name);
        }

        // TODO: Test Edit and delete
    }
}
