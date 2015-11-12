namespace Exam.Server.Api
{
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Common.Constants;
    using Infrastructure.Mapping;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            DatabaseConfig.Initialize();
            AutoMapperConfig.RegisterMappings(Assembly.Load(Assemblies.ServerApi));

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
