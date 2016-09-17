using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rsPortal.web.Startup))]
namespace rsPortal.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
