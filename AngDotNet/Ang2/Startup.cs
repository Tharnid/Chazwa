using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ang2.Startup))]
namespace Ang2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
