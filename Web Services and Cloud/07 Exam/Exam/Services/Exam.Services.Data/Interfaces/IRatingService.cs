namespace Exam.Services.Data.Interfaces
{
    public interface IRatingService
    {
        void RateUser(string userId, int value);
    }
}
