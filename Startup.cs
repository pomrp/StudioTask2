using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudioTask2.Startup))]
namespace StudioTask2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
