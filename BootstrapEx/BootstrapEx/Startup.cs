using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapEx.Startup))]
namespace BootstrapEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
