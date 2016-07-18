using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListKeeper.Startup))]
namespace ListKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
