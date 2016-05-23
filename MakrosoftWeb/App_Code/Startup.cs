using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MakrosoftWeb.Startup))]
namespace MakrosoftWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
