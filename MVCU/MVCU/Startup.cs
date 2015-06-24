using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCU.Startup))]
namespace MVCU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
