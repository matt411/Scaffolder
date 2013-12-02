using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scaffolder.Startup))]
namespace Scaffolder
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
