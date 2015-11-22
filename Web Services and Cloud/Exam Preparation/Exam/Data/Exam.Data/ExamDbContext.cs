namespace Exam.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class ExamDbContext : IdentityDbContext<User>
    {
        public ExamDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Game> Commits { get; set; }

        public static ExamDbContext Create()
        {
            return new ExamDbContext();
        }
    }
}
