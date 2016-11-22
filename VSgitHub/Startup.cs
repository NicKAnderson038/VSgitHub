using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSgitHub.Startup))]
namespace VSgitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
