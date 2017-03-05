using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAdvanced.Session_5.Startup))]
namespace WebAdvanced.Session_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
