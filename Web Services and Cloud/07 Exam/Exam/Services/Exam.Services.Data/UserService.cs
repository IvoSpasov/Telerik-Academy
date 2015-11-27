namespace Exam.Services.Data
{
    using System.Linq;
    using Exam.Data.Common.Repositories;
    using Exam.Data.Models;
    using Interfaces;

    public class UserService : IUserService
    {
        private IRepository<User> usersRepo;
        private IRepository<Rating> ratingsRepo;

        public UserService(IRepository<User> usersRepo, IRepository<Rating> ratingsRepo)
        {
            this.usersRepo = usersRepo;
            this.ratingsRepo = ratingsRepo;
        }

        public string GetUserId(string username)
        {
            return this.usersRepo
                .All()
                .Where(u => u.UserName == username)
                .FirstOrDefault()
                .Id;
        }

        public IQueryable<User> GetUserDetails(string username)
        {
            return this.usersRepo
                .All()
                .Where(u => u.UserName == username);
        }

        public double CalcuateUserRating(string userId)
        {
            double totalUserRating = 0;

            var currentUserRatings = this.ratingsRepo
                .All()
                .Where(r => r.UserId == userId)
                .ToList();

            foreach (var rating in currentUserRatings)
            {
                totalUserRating += rating.Value; 
            }

            double averageUserRating = totalUserRating / currentUserRatings.Count();
            return averageUserRating;
        }
    }
}
