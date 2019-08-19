using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sinemapp.Admin.Startup))]
namespace Sinemapp.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
