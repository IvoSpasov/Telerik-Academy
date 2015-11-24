namespace Exam.Services.Data.Interfaces
{
    using System.Linq;
    using Exam.Data.Models;

    public interface IGamesService
    {
        IQueryable<Game> GetPublicGames(int page = 1);

        Game CreateNewGame(string name, string number, string playerId);

        IQueryable<Game> GetGame(int id);
    }
}
