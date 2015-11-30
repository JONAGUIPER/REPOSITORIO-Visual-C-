using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCNorthwinnd.Startup))]
namespace MVCNorthwinnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
