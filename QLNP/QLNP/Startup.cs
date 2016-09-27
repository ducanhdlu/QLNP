using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLNP.Startup))]
namespace QLNP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
