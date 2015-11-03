namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Repositories;
    using Models;
    using StudentSystem.Models;


    public class HomeworksController : ApiController
    {
        private IGenericRepository<Homework> homeworksRepository;

        public HomeworksController()
            : this(new GenericRepository<Homework>(new StudentSystemDbContext()))
        {
        }

        public HomeworksController(IGenericRepository<Homework> homeworksGenericRepository)
        {
            this.homeworksRepository = homeworksGenericRepository;
        }

        public IHttpActionResult Get()
        {
            var homeworks = this.homeworksRepository
                .All()
                .ToList();

            return this.Ok(homeworks);
        }
    }
}