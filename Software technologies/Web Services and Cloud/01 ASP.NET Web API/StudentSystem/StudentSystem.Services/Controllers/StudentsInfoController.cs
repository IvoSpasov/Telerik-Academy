namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Data.Repositories;
    using Models;
    using StudentSystem.Models;


    public class StudentsInfoController : ApiController
    {
        private IGenericRepository<StudentInfo> studentsInfoRepository;

        public StudentsInfoController()
            : this(new GenericRepository<StudentInfo>(new StudentSystemDbContext()))
        {
        }

        public StudentsInfoController(IGenericRepository<StudentInfo> studentsInfoGenericRepository)
        {
            this.studentsInfoRepository = studentsInfoGenericRepository;
        }

        public IHttpActionResult Get()
        {
            var studentsInfo = this.studentsInfoRepository
                .All()
                .ToList();

            return this.Ok(studentsInfo);
        }
    }
}