using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SouthCoat1.Startup))]
namespace SouthCoat1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
