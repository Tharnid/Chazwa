using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleProjectforTelerik.Startup))]
namespace ExampleProjectforTelerik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
