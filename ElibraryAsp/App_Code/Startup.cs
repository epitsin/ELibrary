using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElibraryAsp.Startup))]
namespace ElibraryAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
