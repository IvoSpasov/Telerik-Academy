namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    
    using Data.Repositories;
    using StudentSystem.Models;


    public class HomeworksController : ApiController
    {
        private IGenericRepository<Homework> homeworksRepository;

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

        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return this.BadRequest("Homework id cannot be null.");
            }

            var homework = this.homeworksRepository
                .GetById(id.Value);

            if (homework == null)
            {
                return this.NotFound();
            }

            return this.Ok(homework);
        }
    }
}