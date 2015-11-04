namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    
    using Data.Repositories;
    using StudentSystem.Models;


    public class StudentsController : ApiController
    {
        private IGenericRepository<Student> studentsRepository;

        public StudentsController(IGenericRepository<Student> studentsGenericRepository)
        {
            this.studentsRepository = studentsGenericRepository;
        }

        public IHttpActionResult Get()
        {
            var students = this.studentsRepository
                .All()
                .ToList();

            return this.Ok(students);
        }
    }
}