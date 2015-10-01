using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQBF.MVC.Startup))]
namespace JQBF.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
