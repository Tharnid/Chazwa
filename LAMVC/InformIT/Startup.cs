using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformIT.Startup))]
namespace InformIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
