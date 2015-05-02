using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_folder.Startup))]
namespace New_folder
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
