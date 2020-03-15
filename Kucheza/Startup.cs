using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kucheza.Startup))]
namespace Kucheza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
