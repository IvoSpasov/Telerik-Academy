namespace MusicSystem.Server.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Data.Models;
    using Infrastructure.Mapping;

    public class SongEditRequestModel : IMapFrom<Song>
    {
        [Required]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public Genre Genre { get; set; }
        
        public string AlbumTitle { get; set; }
        
        public string ArtistName { get; set; }
    }
}