namespace MusicSystem.Server.Api.Models
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class SongResponseModel : IMapFrom<Song>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string Genre { get; set; }
    }
}