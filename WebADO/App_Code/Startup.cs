using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebADO.Startup))]
namespace WebADO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
