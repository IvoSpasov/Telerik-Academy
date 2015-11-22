namespace Exam.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

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
        [MinLength(ValidationConstants.NumberLength)]
        [MaxLength(ValidationConstants.NumberLength)]
        public string RedPlayerNumber { get; set; }

        [MinLength(ValidationConstants.NumberLength)]
        [MaxLength(ValidationConstants.NumberLength)]
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
