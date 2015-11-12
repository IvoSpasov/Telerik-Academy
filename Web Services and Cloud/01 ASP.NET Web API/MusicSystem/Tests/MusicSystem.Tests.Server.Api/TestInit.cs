namespace MusicSystem.Tests.Server.Api
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Common.Constants;
    using System.Reflection;
    using MusicSystem.Server.Infrastructure.Mapping;

    [TestClass]
    public class TestInit
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            AutoMapperConfig.RegisterMappings(Assembly.Load(Assemblies.ServerApi));
        }
    }
}
