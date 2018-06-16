using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatchNav.Startup))]
namespace MatchNav
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
