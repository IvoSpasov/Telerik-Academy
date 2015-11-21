using Exam.Server.Api;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Exam.Server.Api
{
    using System.Web.Http;

    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            var httpConfig = new HttpConfiguration();
            WebApiConfig.Register(httpConfig);
            httpConfig.EnsureInitialized();

            /*
            app
                .UseNinjectMiddleware(NinjectConfig.CeateKernel)
                .UseNinjectWebApi(httpConfig);
            */
        }
    }
}
