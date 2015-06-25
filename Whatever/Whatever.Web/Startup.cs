using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Whatever.Web.Startup))]
namespace Whatever.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
