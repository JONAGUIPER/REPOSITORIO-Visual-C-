using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BebidasMVC.Startup))]
namespace BebidasMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
