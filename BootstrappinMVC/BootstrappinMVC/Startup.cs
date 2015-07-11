using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrappinMVC.Startup))]
namespace BootstrappinMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
