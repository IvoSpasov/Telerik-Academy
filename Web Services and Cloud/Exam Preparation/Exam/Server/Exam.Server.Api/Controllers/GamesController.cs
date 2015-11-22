namespace Exam.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNet.Identity;
    using Models.Games;
    using Services.Data.Interfaces;

    public class GamesController : ApiController
    {
        private IGamesService gamesService;

        public GamesController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        public IHttpActionResult Get(int page = 1)
        {
            var result = this.gamesService
                .GetPublicGames(page)
                .ProjectTo<GameResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(NewGameRequestModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Model cannot be null");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            string userId = this.User.Identity.GetUserId();
            var newGame = this.gamesService.CreateNewGame(model.Name, model.Number, userId);

            var response = this.gamesService
                .GetGame(newGame.Id)
                .ProjectTo<GameResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Format("/api/games/{0}", newGame.Id), response);
        }
    }
}