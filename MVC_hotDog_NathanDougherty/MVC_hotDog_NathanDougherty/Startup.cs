using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_hotDog_NathanDougherty.Startup))]
namespace MVC_hotDog_NathanDougherty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
