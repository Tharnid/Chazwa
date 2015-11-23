using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YlixCRM.Web.Startup))]
namespace YlixCRM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
