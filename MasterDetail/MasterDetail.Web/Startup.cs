using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterDetail.Web.Startup))]
namespace MasterDetail.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
