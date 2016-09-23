using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SouthCoat.Startup))]
namespace SouthCoat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
