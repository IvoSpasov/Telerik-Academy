namespace MusicSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Artist
    {
        private ICollection<Song> songs;

        public Artist()
        {
            this.Songs = new HashSet<Song>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public virtual ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
