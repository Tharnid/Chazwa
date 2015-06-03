using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParentChildData.Web.Startup))]
namespace ParentChildData.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
