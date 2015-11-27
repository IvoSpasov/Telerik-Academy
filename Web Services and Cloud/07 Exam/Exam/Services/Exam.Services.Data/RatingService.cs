namespace Exam.Services.Data
{
    using Exam.Data.Common.Repositories;
    using Exam.Data.Models;
    using Interfaces;

    public class RatingService : IRatingService
    {
        private IRepository<Rating> ratingsRepo;

        public RatingService(IRepository<Rating> ratingsRepo)
        {
            this.ratingsRepo = ratingsRepo;
        }

        public void RateUser(string userId, int value)
        {
            // validate userId
            var newRating = new Rating
            {
                UserId = userId,
                Value = value
            };

            this.ratingsRepo.Add(newRating);
            this.ratingsRepo.SaveChanges();
        }
    }
}
