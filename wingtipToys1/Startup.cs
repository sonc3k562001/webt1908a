using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wingtipToys1.Startup))]
namespace wingtipToys1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
