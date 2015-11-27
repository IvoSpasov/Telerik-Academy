namespace Exam.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Models.Users;
    using Services.Data.Interfaces;

    public class UsersController : ApiController
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("api/Users/{username}")]
        public IHttpActionResult Get(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return this.BadRequest("You must provide username");
            }

            var result = this.userService
                .GetUserDetails(username)
                .ProjectTo<UserDetailsResponseModel>()
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            string userId = this.userService.GetUserId(username);
            result.Rating = this.userService.CalcuateUserRating(userId);

            return this.Ok(result);
        }
    }
}