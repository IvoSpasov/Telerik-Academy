namespace MusicSystem.Tests.Services.Data.TestObjects
{
    using MusicSystem.Data.Models;
    using System;

    public static class TestObjectFactory
    {
        public static InMemoryRepository<Song> GetSongsRepository()
        {
            var songsRepository = new InMemoryRepository<Song>();

            for (int i = 0; i < 25; i++)
            {
                songsRepository.Add(new Song()
                {
                    Id = i,
                    Title = "Song title " + i,
                    Genre = Genre.Rock,
                    Year = (1980 + i).ToString()
                });
            }

            return songsRepository;
        }

        public static InMemoryRepository<Album> GetAlbumsRepository()
        {
            var albumsRepository = new InMemoryRepository<Album>();

            for (int i = 0; i < 25; i++)
            {
                albumsRepository.Add(new Album()
                {
                    Id = i,
                    Title = "Album title " + i,
                    Year = (1980 + i).ToString(),
                    Producer = "Album producer " + i
                });
            }

            return albumsRepository;
        }

        public static InMemoryRepository<Artist> GetArtistsRepository()
        {
            var artistsRepository = new InMemoryRepository<Artist>();

            for (int i = 0; i < 25; i++)
            {
                var dateOfBirth = new DateTime(1980, 1, 1).AddMonths(i);

                artistsRepository.Add(new Artist()
                {
                    Id = i,
                    Name = "Artist name " + i,
                    CountryName = "Country name " + i,
                    DateOfBirth = dateOfBirth
                });
            }

            return artistsRepository;
        }
    }
}
