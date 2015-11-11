namespace MusicSystem.Services.Data
{
    using System;
    using System.Linq;
    
    using Interfaces;
    using MusicSystem.Data.Common.Repositories;
    using MusicSystem.Data.Models;

    public class SongsService : ISongsService
    {
        private IRepository<Song> songsRepository;
        private IRepository<Album> albumsRepository;
        private IRepository<Artist> artistsRepository;

        public SongsService(
            IRepository<Song> songsRepository,
            IRepository<Album> albumsRepository,
            IRepository<Artist> artistsRepository)
        {
            this.songsRepository = songsRepository;
            this.albumsRepository = albumsRepository;
            this.artistsRepository = artistsRepository;
        }

        public int Add(string title, string year, Genre genre, string albumTitle, string artistName)
        {
            var albumFromDb = this.GetAlbumFromDb(albumTitle);
            var artistFromDb = this.GetArtistFromDb(artistName);
            var newSong = new Song
            {
                Title = title,
                Year = year,
                Genre = genre,
                Album = albumFromDb,
                Artist = artistFromDb
            };

            this.songsRepository.Add(newSong);
            this.songsRepository.SaveChanges();

            return newSong.Id;
        }

        private Album GetAlbumFromDb(string albumTitle)
        {
            if (string.IsNullOrEmpty(albumTitle))
            {
                throw new ArgumentNullException("albumTitle", "No album title");
            }

            var albumFromDb = this.albumsRepository
                .All()
                .FirstOrDefault(a => a.Title == albumTitle);

            if (albumFromDb == null)
            {
                throw new ArgumentException("Album not found");
            }

            return albumFromDb;
        }

        private Artist GetArtistFromDb(string artistName)
        {
            if (string.IsNullOrEmpty(artistName))
            {
                throw new ArgumentNullException("artistName", "No artist name");
            }

            var artistFromDb = this.artistsRepository
                .All()
                .FirstOrDefault(a => a.Name == artistName);

            if (artistFromDb == null)
            {
                throw new ArgumentException("Artist not found");
            }

            return artistFromDb;
        }
    }
}
