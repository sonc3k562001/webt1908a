using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fiml.Startup))]
namespace fiml
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
