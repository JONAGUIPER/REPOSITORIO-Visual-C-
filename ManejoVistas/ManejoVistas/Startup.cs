using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManejoVistas.Startup))]
namespace ManejoVistas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
