using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LLMVC.Startup))]
namespace LLMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
