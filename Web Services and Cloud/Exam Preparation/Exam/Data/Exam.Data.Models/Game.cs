namespace Exam.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public string RedUserId { get; set; }

        public virtual User RedUser { get; set; }

        public string BlueUserId { get; set; }

        public virtual User BlueUser { get; set; }
    }
}
