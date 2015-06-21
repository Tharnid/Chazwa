using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapBusSetup.Startup))]
namespace BootstrapBusSetup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
