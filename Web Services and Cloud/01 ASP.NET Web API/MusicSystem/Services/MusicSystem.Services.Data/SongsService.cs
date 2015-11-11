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

        public IQueryable<Song> All()
        {
            return this.songsRepository
                .All();
        }

        public Song SongById(int id)
        {
            return this.songsRepository
                .GetById(id);
        }

        public int Add(Song song, string albumTitle, string artistName)
        {
            song.Album = this.GetAlbumFromDb(albumTitle);
            song.Artist = this.GetArtistFromDb(artistName);
            this.songsRepository.Add(song);
            this.songsRepository.SaveChanges();

            return song.Id;
        }

        public int Edit(Song song, string albumTitle, string artistName)
        {
            if (!string.IsNullOrEmpty(albumTitle))
            {
                song.Album = this.GetAlbumFromDb(albumTitle);
            }
            if (!string.IsNullOrEmpty(artistName))
            {
                song.Artist = this.GetArtistFromDb(artistName);
            }

            this.songsRepository.Update(song);
            this.songsRepository.SaveChanges();

            return song.Id;
        }

        public void Delete(int id)
        {
            this.songsRepository.Delete(id);
            this.songsRepository.SaveChanges();
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
