namespace Exam.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        private ICollection<Guess> guesses;

        public Game()
        {
            this.Guesses = new HashSet<Guess>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public GameState GameState { get; set; }

        [Required]
        public string RedPlayerNumber { get; set; }

        public string BluePlayerNumber { get; set; }

        public string RedPlayerId { get; set; }

        public virtual User RedPlayer { get; set; }

        public string BluePlayerId { get; set; }

        public virtual User BluePlayer { get; set; }

        public virtual ICollection<Guess> Guesses
        {
            get { return this.guesses; }
            set { this.guesses = value; }
        }
    }
}
