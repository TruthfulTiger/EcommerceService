using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceClient.Startup))]
namespace ECommerceClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
