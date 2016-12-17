using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiveMe.Startup))]
namespace GiveMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
