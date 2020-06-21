using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALL_MVC_ALL.Startup))]
namespace ALL_MVC_ALL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
