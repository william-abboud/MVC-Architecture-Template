using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Architecture.Startup))]
namespace Architecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
