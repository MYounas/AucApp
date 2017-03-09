using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AucApp.Startup))]
namespace AucApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
