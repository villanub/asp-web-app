using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_app_net.Startup))]
namespace web_app_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
