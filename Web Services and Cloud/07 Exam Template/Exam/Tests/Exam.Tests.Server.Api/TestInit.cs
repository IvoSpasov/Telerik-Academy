namespace Exam.Tests.Server.Api
{
    using System.Reflection;
    using System.Web.Http;

    using Common.Constants;
    using Exam.Server.Api;
    using Exam.Server.Infrastructure.Mapping;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;

    [TestClass]
    public class TestInit
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            AutoMapperConfig.RegisterMappings(Assembly.Load(Assemblies.ServerApi));

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            MyWebApi.IsUsing(config);
        }
    }
}
