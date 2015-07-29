using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROMVCAF.Startup))]
namespace PROMVCAF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
