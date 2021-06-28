using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rozgar.Startup))]
namespace Rozgar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
