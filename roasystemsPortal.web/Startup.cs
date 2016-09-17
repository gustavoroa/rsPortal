using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(roasystemsPortal.web.Startup))]
namespace roasystemsPortal.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
