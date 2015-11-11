namespace MusicSystem.Services.Data.Interfaces
{
    using System.Linq;
    using MusicSystem.Data.Models;

    public interface ISongsService
    {
        IQueryable<Song> All();
        Song SongById(int id);
        int Add(Song song, string albumTitle, string artistName);
        int Edit(int id, string title, string year, Genre genre, string albumTitle, string artistName);
        void Delete(int id);
    }
}
