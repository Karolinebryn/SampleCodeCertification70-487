using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFramework.Startup))]
namespace EntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
