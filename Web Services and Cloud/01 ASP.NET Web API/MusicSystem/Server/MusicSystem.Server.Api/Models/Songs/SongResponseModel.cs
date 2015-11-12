namespace MusicSystem.Server.Api.Models.Songs
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class SongResponseModel : IMapFrom<Song>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public Genre Genre { get; set; }
    }
}