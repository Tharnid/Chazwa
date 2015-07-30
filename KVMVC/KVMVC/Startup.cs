using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KVMVC.Startup))]
namespace KVMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
