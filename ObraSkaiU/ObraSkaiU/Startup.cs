using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObraSkaiU.Startup))]
namespace ObraSkaiU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
