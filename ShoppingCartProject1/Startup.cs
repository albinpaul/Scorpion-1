using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingCartProject1.Startup))]
namespace ShoppingCartProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
