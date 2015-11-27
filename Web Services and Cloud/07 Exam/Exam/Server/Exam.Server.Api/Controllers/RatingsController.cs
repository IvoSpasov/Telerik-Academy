namespace Exam.Server.Api.Controllers
{
    using System.Web.Http;
    using Microsoft.AspNet.Identity;
    using Models.Rates;
    using Services.Data.Interfaces;

    public class RatingsController : ApiController
    {
        private IRatingService ratingService;

        public RatingsController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }

        [Route("api/Users/Rate")]
        public IHttpActionResult Put(CreateNewRateRequestModel model)
        {
            if (model == null)
            {
                return this.BadRequest("Model cannot be null");
            }

            string currentUserId = this.User.Identity.GetUserId();

            if (currentUserId == model.UserId)
            {
                this.ModelState.AddModelError("UserId", "You cannot rate yourself");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.ratingService.RateUser(model.UserId, model.Value);

            return this.Ok();
        }
    }
}