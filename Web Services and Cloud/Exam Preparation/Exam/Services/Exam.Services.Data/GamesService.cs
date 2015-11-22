namespace Exam.Services.Data
{
    using System;
    using System.Linq;
    using Exam.Data.Common.Repositories;
    using Exam.Data.Models;
    using Interfaces;

    public class GamesService : IGamesService
    {
        private IRepository<Game> games;

        public GamesService(IRepository<Game> games)
        {
            this.games = games;
        }

        public Game CreateNewGame(string name, string number, string playerId)
        {
            var newGame = new Game()
            {
                Name = name,
                RedPlayerNumber = number,
                GameState = GameState.WaitingForOpponent,
                DateCreated = DateTime.Now,
                RedPlayerId = playerId
            };

            this.games.Add(newGame);
            this.games.SaveChanges();

            return newGame;
        }

        public IQueryable<Game> GetGame(int id)
        {
            return this.games
                .All()
                .Where(g => g.Id == id);
        }
    }
}
