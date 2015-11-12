namespace Exam.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class ExamDbContext : IdentityDbContext<User>
    {
        public ExamDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Test> Commits { get; set; }

        public static ExamDbContext Create()
        {
            return new ExamDbContext();
        }
    }
}
