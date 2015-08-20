using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SgsMvcApp.Startup))]
namespace SgsMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
