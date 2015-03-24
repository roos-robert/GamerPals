using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamePal.Startup))]
namespace GamePal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
