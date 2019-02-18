using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductFirstVersion.Startup))]
namespace ProductFirstVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
