namespace MusicSystem.Tests.Server.Api
{
    using System.Reflection;
    using System.Web.Http;

    using Common.Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MusicSystem.Server.Api;
    using MusicSystem.Server.Infrastructure.Mapping;
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
