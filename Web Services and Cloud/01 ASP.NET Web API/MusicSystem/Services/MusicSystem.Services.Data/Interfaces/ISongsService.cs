namespace MusicSystem.Services.Data.Interfaces
{
    public interface ISongsService
    {
        int Add(string title, string year, string genre, string albumTitle, string artistName);
    }
}
