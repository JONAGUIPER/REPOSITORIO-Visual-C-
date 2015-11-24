using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFotos.Startup))]
namespace MVCFotos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
