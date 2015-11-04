namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Repositories;
    using Models;
    using StudentSystem.Models;

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

        public IHttpActionResult Post(CourseRequestModel course)
        {
            if (!ModelState.IsValid || course == null)
            {
                return this.BadRequest(this.ModelState);
            }

            Course newCourse = new Course()
            {
                Name = course.Name,
                Description = course.Description
            };

            this.coursesRepository.Add(newCourse);
            this.coursesRepository.SaveChanges();

            return this.Ok();
        }
    }
}