using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1Furniture.Startup))]
namespace Assignment1Furniture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
