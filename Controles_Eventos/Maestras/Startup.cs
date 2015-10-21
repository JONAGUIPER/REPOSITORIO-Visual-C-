using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maestras.Startup))]
namespace Maestras
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
