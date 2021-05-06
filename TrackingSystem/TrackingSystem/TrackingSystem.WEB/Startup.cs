using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackingSystem.WEB.Startup))]
namespace TrackingSystem.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
