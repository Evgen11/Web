using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWeb.Startup))]
namespace FinalWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
