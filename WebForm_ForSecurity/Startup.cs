using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_ForSecurity.Startup))]
namespace WebForm_ForSecurity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
