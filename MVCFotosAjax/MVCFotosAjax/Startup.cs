using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFotosAjax.Startup))]
namespace MVCFotosAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            //ConfigureAuth(app);
        }
    }
}
