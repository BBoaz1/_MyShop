using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_myShop.WebUI.Startup))]
namespace _myShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
