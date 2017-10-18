using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppJeff.Startup))]
namespace WebAppJeff
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
