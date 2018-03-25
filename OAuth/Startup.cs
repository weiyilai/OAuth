using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuth.Startup))]
namespace OAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
