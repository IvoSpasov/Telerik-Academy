namespace MusicSystem.Server.Api.Models.Songs
{
    using System.ComponentModel.DataAnnotations;

    using Data.Models;
    using Infrastructure.Mapping;

    public class SongRequestModel : IMapFrom<Song>
    {
        [Required]
        public string Title { get; set; }

        public string Year { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public string AlbumTitle { get; set; }

        [Required]
        public string ArtistName { get; set; }
    }
}