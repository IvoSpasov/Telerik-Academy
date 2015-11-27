namespace Exam.Server.Wcf
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Common.Repositories;
    using Data.Models;
    using Models;

    public class Users : IUsers
    {
        private IRepository<User> usersRepo;

        public Users()
            : this(new EfGenericRepository<User>(new ExamDbContext()))
        {
        }

        public Users(IRepository<User> usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        public IEnumerable<UserResponseModel> Top()
        {
            var result = this.usersRepo
                .All()
                .Select(u => new UserResponseModel()
                {
                    Rating = u.Ratings.FirstOrDefault().Value,
                    UserName = u.UserName
                })
                .Take(10)
                .ToList();

            return result;
        }        
    }
}
