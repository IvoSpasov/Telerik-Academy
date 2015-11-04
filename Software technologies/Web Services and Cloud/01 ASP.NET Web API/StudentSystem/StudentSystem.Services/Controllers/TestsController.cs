namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    
    using Data.Repositories;
    using StudentSystem.Models;

    public class TestsController : ApiController
    {
        private IGenericRepository<Test> testsRepository;

        public TestsController(IGenericRepository<Test> testGenericRepository)
        {
            this.testsRepository = testGenericRepository;
        }

        public IHttpActionResult Get()
        {
            var tests = this.testsRepository
                .All()
                .ToList();

            return this.Ok(tests);
        }
    }
}