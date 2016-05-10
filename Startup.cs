using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(firstgitproject.Startup))]
namespace firstgitproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
