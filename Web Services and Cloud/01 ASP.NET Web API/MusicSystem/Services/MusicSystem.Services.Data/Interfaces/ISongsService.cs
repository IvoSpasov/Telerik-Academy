namespace MusicSystem.Services.Data.Interfaces
{
    using MusicSystem.Data.Models;

    public interface ISongsService
    {
        int Add(string title, string year, Genre genre, string albumTitle, string artistName);
    }
}
