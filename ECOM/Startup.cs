using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECOM.Startup))]
namespace ECOM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
