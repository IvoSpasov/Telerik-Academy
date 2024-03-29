﻿namespace Exam.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Guess
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public DateTime DateMade { get; set; }

        [Required]
        public int CowsCount { get; set; }

        [Required]
        public int BullsCount { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; }
    }
}
