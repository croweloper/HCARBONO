using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuellaCarbonoWeb.Startup))]
namespace HuellaCarbonoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
