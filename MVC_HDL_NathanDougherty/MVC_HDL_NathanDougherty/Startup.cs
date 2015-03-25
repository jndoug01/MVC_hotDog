using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HDL_NathanDougherty.Startup))]
namespace MVC_HDL_NathanDougherty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
