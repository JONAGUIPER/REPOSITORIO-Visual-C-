using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Nobel.Startup))]
namespace MVC_Nobel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
