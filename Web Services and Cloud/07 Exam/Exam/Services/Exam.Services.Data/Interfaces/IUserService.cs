namespace Exam.Services.Data.Interfaces
{
    using System.Linq;
    using Exam.Data.Models;

    public interface IUserService
    {
        string GetUserId(string username);

        IQueryable<User> GetUserDetails(string username);

        double CalcuateUserRating(string username);
    }
}
