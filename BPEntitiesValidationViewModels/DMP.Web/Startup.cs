using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMP.Web.Startup))]
namespace DMP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
