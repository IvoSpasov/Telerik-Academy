namespace Exam.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class ExamDbContext : IdentityDbContext<User>
    {
        public ExamDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ExamDbContext Create()
        {
            return new ExamDbContext();
        }
    }
}
