using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hades.Startup))]
namespace Hades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
