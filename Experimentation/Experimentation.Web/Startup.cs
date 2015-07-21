using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Experimentation.Web.Startup))]
namespace Experimentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
