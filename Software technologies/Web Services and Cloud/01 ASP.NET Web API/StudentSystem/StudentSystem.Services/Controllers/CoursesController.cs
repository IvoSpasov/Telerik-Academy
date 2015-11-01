namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data.Repositories;
    using Models;
    using Data;

    public class CoursesController : ApiController
    {
        private IGenericRepository<Course> coursesRepository;

        public CoursesController()
            : this(new GenericRepository<Course>(new StudentSystemDbContext()))
        {
        }

        public CoursesController(IGenericRepository<Course> coursesGenericRepository)
        {
            this.coursesRepository = coursesGenericRepository;
        }

        public IHttpActionResult Get()
        {
            var courses = this.coursesRepository
                .All()
                .ToList();

            return this.Ok(courses);
        }
    }
}