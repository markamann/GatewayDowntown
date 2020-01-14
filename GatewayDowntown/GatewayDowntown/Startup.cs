using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GatewayDowntown.Startup))]
namespace GatewayDowntown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
