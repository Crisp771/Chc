using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chc.Startup))]
namespace Chc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
