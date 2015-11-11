namespace MusicSystem.Tests.Services.Data.TestObjects
{
    using MusicSystem.Data.Models;

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
    }
}
