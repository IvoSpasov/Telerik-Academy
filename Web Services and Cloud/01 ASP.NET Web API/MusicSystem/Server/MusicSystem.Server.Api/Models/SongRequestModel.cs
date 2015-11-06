﻿namespace MusicSystem.Server.Api.Models
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class SongRequestModel : IMapFrom<Song>
    {
        [Required]
        public string Title { get; set; }

        public string Year { get; set; }

        public string Genre { get; set; }

        [Required]
        public string AlbumTitle { get; set; }

        [Required]
        public string ArtistName { get; set; }
    }
}