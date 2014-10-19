using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCasePlatform.Web.Frontend.Startup))]
namespace TestCasePlatform.Web.Frontend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
