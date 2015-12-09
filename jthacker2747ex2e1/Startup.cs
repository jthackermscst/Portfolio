using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jthacker2747ex2e1.Startup))]
namespace jthacker2747ex2e1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
