using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChildGridsHowTo.Startup))]
namespace ChildGridsHowTo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
