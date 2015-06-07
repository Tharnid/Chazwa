using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfMVC.Web.Startup))]
namespace ProfMVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
