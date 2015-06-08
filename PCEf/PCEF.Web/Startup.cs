using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCEF.Web.Startup))]
namespace PCEF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
