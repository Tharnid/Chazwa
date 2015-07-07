using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NavbarDataDriven.Startup))]
namespace NavbarDataDriven
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
