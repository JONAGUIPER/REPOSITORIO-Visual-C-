using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REPOSITORIO_Visual_C_.Startup))]
namespace REPOSITORIO_Visual_C_
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
