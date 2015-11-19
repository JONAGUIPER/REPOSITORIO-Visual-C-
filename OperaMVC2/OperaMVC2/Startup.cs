using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OperaMVC2.Startup))]
namespace OperaMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
