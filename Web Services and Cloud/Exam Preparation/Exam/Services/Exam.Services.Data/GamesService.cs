namespace Exam.Services.Data
{
    using System;
    using System.Linq;
    using Common.Constants;
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

        public IQueryable<Game> GetPublicGames(int page = 1)
        {
            var result = this.games
                .All()
                .Where(g => g.GameState == GameState.WaitingForOpponent)
                .OrderBy(g => g.GameState)
                .ThenBy(g => g.Name)
                .ThenBy(g => g.DateCreated)
                .ThenBy(g => g.RedPlayer.Email)
                .Skip((page - 1) * ValidationConstants.GamesPerPage)
                .Take(ValidationConstants.GamesPerPage);

            return result;
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
